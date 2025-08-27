using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using SFDashboard.Models;
using SFDashboard.Infrastructure;
using System.Data;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Drawing.Drawing2D;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics.Contracts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SFDashboard.SFModels;

namespace SFDashboard.Controllers
{
    public class DashboardModelController : Controller
    {
        private readonly DashboardDbContext _context;
        private readonly SFDbContext _sfcontext;
        private readonly IDashBoardDetailsRepository _dbdetailrepo;
        public DashboardModelController(DashboardDbContext context, SFDbContext context2, IDashBoardDetailsRepository dbdetailrepo)
        {
            _context = context;
            _sfcontext = context2;
            _dbdetailrepo = dbdetailrepo;
        }


        // GET: DashboardModel
        public async Task<IActionResult> Index()
        {

            if (HttpContext.Session.GetString("SessionKeyUsername") == null || HttpContext.Session.GetString("SessionKeyUsername") == "")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                int countdatagraph = 1;
                int countdatatable = 1;
                var Dashboards = new List<DashBoardDetails>();
                var tabuser = new List<TabDetail>();
                var listValues = new List<object>();
                var lstgraph = new List<GraphBox>();
                var viewModel = new List<TabDetail>();
                var tabs = new List<Tab>();
                if (HttpContext.Session.GetString("SessionCustomerCode") == "ALL" || HttpContext.Session.GetString("SessionCustomerCode") == null || HttpContext.Session.GetString("SessionCustomerCode") == "")
                {
                    Dashboards = _context.DashBoardDetails.Where(x => x.ArchiveFlag == "1").ToList();

                }
                else
                {

                    tabuser = _context.TabDetails.Where(x => x.UserId == HttpContext.Session.GetString("SessionKeyUsername")).OrderBy(x => x.TabCode).ThenBy(x => x.DashBoardName).ThenBy(n => n.code2).ThenBy(n => n.Code).ToList();
                   
                    foreach(var item in tabuser)
                    {
                        Tab tb = new Tab();
                        tb = _context.Tab.Where(x => x.TabCode == item.TabCode).SingleOrDefault();
                        item.tab = tb;
                    }
                    
                    // Dashboards = _context.DashBoardDetails.Join(_context.TabDetails,i=>i.DashBoardName,j=>j.Code,k=>k.code2 , (_i,_j,_k)=> new {dn= _i,c=_j,c2=_k }).Where(x => x.ArchiveFlag == "1").ToList();
                    var check = from s in tabuser select s.TabCode;
                    tabs = _context.Tab.Where(x => check.Contains(x.TabCode)).ToList();
                    int counttabuser = _context.Tab.Where(x => check.Contains(x.TabCode)).Count();

                    ViewBag.Tab = JsonConvert.SerializeObject(tabs).Replace("TabDescription", "text").Replace("TabCode", "id");
                    ViewBag.TabUser = tabs;
                    ViewBag.CountTab = counttabuser;

                }
                foreach (var tab in tabs)
                {
                    if (!string.IsNullOrEmpty(tab.SourceFilter))
                    {
                        var tuser = tabuser.Where(x => x.tab.TabCode == tab.TabCode).FirstOrDefault();
                        
                       UserAccessID uID = _context.UserAccessID.Where(x => x.UserId == tuser.CustomerCode).FirstOrDefault();

                        String cs = @"Data Source="+uID.ServerName+";Initial Catalog="+uID.DBName+";Persist Security Info=True;User ID="+uID.LoginID+";Password="+uID.PassDB+";";
                        using (SqlConnection connection = new SqlConnection(cs))
                        {

                            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                            builder.ConnectionString = cs;
                            string server = builder.DataSource;
                            string database = builder.InitialCatalog;
                            DataTable schemaTable;
                            SqlDataReader myReader;

                            try
                            {
                                if (connection.State != ConnectionState.Open)
                                {
                                    connection.Open();
                                    using (SqlCommand command = new SqlCommand("", connection))
                                    {

                                        command.CommandText = tab.SourceFilter;
                                        command.CommandType = CommandType.StoredProcedure;
                                        using (myReader = command.ExecuteReader())
                                        {

                                            //Retrieve column schema into a DataTable.
                                            schemaTable = myReader.GetSchemaTable();
                                            string? ColumnNameTemp, ValueTemp;
                                            var values = new List<Dictionary<string, object>>();


                                            while (myReader.Read())
                                            {
                                                var fieldValues = new Dictionary<string, object>();

                                                foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                                {
                                                    ColumnNameTemp = rowColumn[0].ToString();
                                                    ValueTemp = myReader[ColumnNameTemp].ToString();
                                                    fieldValues.Add(ColumnNameTemp, ValueTemp);


                                                }
                                                values.Add(fieldValues);
                                            }
                                            //ViewBag.BusinessParty = values;
                                            tab.DataFilter = values;
                                        }

                                    }
                                }
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }

                foreach (var tabdetail in tabuser)
                {
                    var d = new DashBoardDetails();
                    d = _context.DashBoardDetails.Where(x => x.ArchiveFlag == "1" && x.DashBoardName == tabdetail.DashBoardName && x.Code == tabdetail.Code && x.code2 == tabdetail.code2 && x.CustomerCode == tabdetail.CustomerCode).SingleOrDefault();

                    if (d != null)
                    {
                        tabdetail.dbdashboard = d;
                        //foreach (var d in Dashboards)
                        //{
                        //d.tabCode = tabdetail.TabCode;
                        if (d.Type == "Fixed")
                        {
                            //viewModel.Add(new DashBoardDetails { DashBoardName = d.DashBoardName, code2 = d.code2, LabelName = d.LabelName, Value = d.Value });
                            viewModel.Add(tabdetail);
                        }
                        else if (d.Type == "SP")
                        {
                            String cs = @"Data Source=" + d.ServerName + ";Initial Catalog=" + d.DBName + ";Persist Security Info=True;User ID=" + d.LoginID + ";Password=" + d.Password;
                            using (SqlConnection connection = new SqlConnection(cs))
                            {

                                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                                builder.ConnectionString = cs;
                                string server = builder.DataSource;
                                string database = builder.InitialCatalog;
                                DataTable schemaTable;
                                SqlDataReader myReader;

                                try
                                {
                                    if (connection.State != ConnectionState.Open)
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand("", connection))
                                        {

                                            command.CommandText = d.Source;
                                            Parameter(d, command);

                                            command.CommandType = CommandType.StoredProcedure;

                                            using (myReader = await command.ExecuteReaderAsync())
                                            {
                                                //Retrieve column schema into a DataTable.
                                                schemaTable = myReader.GetSchemaTable();
                                                string? ColumnNameTemp;
                                                while (myReader.Read())
                                                {
                                                    foreach (DataRow rowColumn in schemaTable.Rows)
                                                    {
                                                        ColumnNameTemp = rowColumn[0].ToString();
                                                        //d.ListInformationBox.Add(new InformationBox(ColumnNameTemp, myReader[ColumnNameTemp].ToString()));
                                                        tabdetail.dbdashboard.ListInformationBox.Add(new InformationBox(ColumnNameTemp, myReader[ColumnNameTemp].ToString()));
                                                    }
                                                }
                                                //d.Value = d.ListInformationBox.Count();
                                                tabdetail.dbdashboard.Value = d.ListInformationBox.Count();
                                            }

                                            viewModel.Add(tabdetail);
                                        }
                                    }
                                }

                                finally
                                {
                                    connection.Close();
                                }
                                if (d.GraphData != null && d.GraphData != "")
                                {
                                    d.dataCount = countdatagraph;
                                    try
                                    {
                                        if (connection.State != ConnectionState.Open)
                                        {
                                            connection.Open();
                                            using (SqlCommand command = new SqlCommand("", connection))
                                            {

                                                command.CommandText = d.GraphData;
                                                Parameter(d, command);

                                                command.CommandType = CommandType.StoredProcedure;

                                                using (myReader = await command.ExecuteReaderAsync())
                                                {
                                                    var xaxis = new List<string>();
                                                    var legend = new List<string>();
                                                    var lstvalue = new List<Array>();
                                                    //Retrieve column schema into a DataTable.
                                                    schemaTable = myReader.GetSchemaTable();
                                                    string? ColumnNameTemp;

                                                    for (int i = 0; i < myReader.FieldCount; i++)
                                                    {
                                                        if (i > 0)
                                                        {
                                                            xaxis.Add(myReader.GetName(i));
                                                        }

                                                    }
                                                    while (myReader.Read())
                                                    {
                                                        int counter = 0;
                                                        var value = new List<string>();
                                                        foreach (DataRow rowColumn in schemaTable.Rows)
                                                        {
                                                            ColumnNameTemp = rowColumn[0].ToString();
                                                            if (counter == 0)
                                                            {
                                                                legend.Add(myReader[ColumnNameTemp].ToString());
                                                            }
                                                            else
                                                            {
                                                                string str = myReader[ColumnNameTemp].ToString() == "" ? "0" : myReader[ColumnNameTemp].ToString();
                                                                value.Add(str);
                                                            }

                                                            counter++;
                                                        }
                                                        lstvalue.Add(value.ToArray());

                                                    }
                                                    GraphBox graph = new GraphBox(xaxis, legend, lstvalue);
                                                    lstgraph.Add(graph);


                                                }

                                            }
                                        }
                                    }

                                    finally
                                    {
                                        connection.Close();
                                    }
                                    countdatagraph++;
                                }
                                try
                                {
                                    if (connection.State != ConnectionState.Open)
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand("", connection))
                                        {

                                            command.CommandText = @"sp_GetCityDashboard";
                                            command.CommandType = CommandType.StoredProcedure;
                                            using (myReader = command.ExecuteReader())
                                            {

                                                //Retrieve column schema into a DataTable.
                                                schemaTable = myReader.GetSchemaTable();
                                                string? ColumnNameTemp, ValueTemp;
                                                var values = new List<Dictionary<string, object>>();


                                                while (myReader.Read())
                                                {
                                                    var fieldValues = new Dictionary<string, object>();
                                                    //var tempLabel = new List<string>();
                                                    //var tempValue = new List<string>();
                                                    foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                                    {
                                                        ColumnNameTemp = rowColumn[0].ToString();
                                                        ValueTemp = myReader[ColumnNameTemp].ToString();
                                                        fieldValues.Add(ColumnNameTemp, ValueTemp);
                                                        //    InformationBox countrybox = new InformationBox(ColumnNameTemp, ValueTemp);

                                                    }
                                                    values.Add(fieldValues);
                                                }
                                                ViewBag.City = values;
                                            }

                                            // viewModel.Add(d);
                                        }
                                    }
                                }
                                finally
                                {
                                    connection.Close();
                                }

                                //try
                                //{
                                //    if (connection.State != ConnectionState.Open)
                                //    {
                                //        connection.Open();
                                //        using (SqlCommand command = new SqlCommand("", connection))
                                //        {

                                //            command.CommandText = @"sp_GetCustomerDashboard";
                                //            command.CommandType = CommandType.StoredProcedure;
                                //            using (myReader = command.ExecuteReader())
                                //            {

                                //                //Retrieve column schema into a DataTable.
                                //                schemaTable = myReader.GetSchemaTable();
                                //                string? ColumnNameTemp, ValueTemp;
                                //                var values = new List<Dictionary<string, object>>();


                                //                while (myReader.Read())
                                //                {
                                //                    var fieldValues = new Dictionary<string, object>();

                                //                    foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                //                    {
                                //                        ColumnNameTemp = rowColumn[0].ToString();
                                //                        ValueTemp = myReader[ColumnNameTemp].ToString();
                                //                        fieldValues.Add(ColumnNameTemp, ValueTemp);


                                //                    }
                                //                    values.Add(fieldValues);
                                //                }
                                //                ViewBag.BusinessParty = values;
                                //            }

                                //        }
                                //    }
                                //}
                                //finally
                                //{
                                //    connection.Close();
                                //}
                            }

                        }
                        else if (d.Type == "VW")
                        {
                            String cs = @"Data Source=" + d.ServerName + ";Initial Catalog=" + d.DBName + ";Persist Security Info=True;User ID=" + d.LoginID + ";Password=" + d.Password;
                            using (SqlConnection connection = new SqlConnection(cs))
                            {

                                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                                builder.ConnectionString = cs;
                                string server = builder.DataSource;
                                string database = builder.InitialCatalog;
                                DataTable schemaTable;
                                try
                                {
                                    if (connection.State != ConnectionState.Open)
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand("", connection))
                                        {

                                            command.CommandText = @"SELECT * FROM " + d.Source;
                                            using (var myReader = await command.ExecuteReaderAsync())
                                            {
                                                //Retrieve column schema into a DataTable.
                                                schemaTable = myReader.GetSchemaTable();
                                                string? ColumnNameTemp, ValueTemp;
                                                while (myReader.Read())
                                                {
                                                    var tempLabel = new List<string>();
                                                    var tempValue = new List<string>();
                                                    foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                                    {
                                                        ColumnNameTemp = rowColumn[0].ToString();
                                                        ValueTemp = myReader[ColumnNameTemp].ToString();
                                                        InformationBox ibox = new InformationBox(ColumnNameTemp, ValueTemp);
                                                        //d.ListInformationBox.Add(ibox);
                                                        tabdetail.dbdashboard.ListInformationBox.Add(ibox);
                                                    }
                                                }
                                                //d.Value = d.ListInformationBox.Count();
                                                tabdetail.dbdashboard.Value = d.ListInformationBox.Count();
                                            }
                                            viewModel.Add(tabdetail);
                                        }
                                    }
                                }
                                finally
                                {
                                    connection.Close();
                                }
                            }
                        }
                        else if (d.Type.StartsWith("Table"))
                        {

                            String cs = @"Data Source=" + d.ServerName + ";Initial Catalog=" + d.DBName + ";Persist Security Info=True;User ID=" + d.LoginID + ";Password=" + d.Password;

                            using (SqlConnection connection = new SqlConnection(cs))
                            {

                                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
                                builder.ConnectionString = cs;
                                string server = builder.DataSource;
                                string database = builder.InitialCatalog;

                                try
                                {
                                    if (connection.State != ConnectionState.Open)
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand("", connection))
                                        {
                                            DataTable schemaTable;
                                            SqlDataReader myReader;
                                            tabdetail.dbdashboard.dataCount = countdatatable;
                                            if (d.Type == "TableQuery")
                                            {
                                                command.CommandText = d.Notes;
                                            }
                                            else if (d.Type == "TableVw")
                                            {
                                                command.CommandText = @"SELECT * FROM " + d.Source;
                                            }
                                            else if (d.Type == "TableSp")
                                            {
                                                command.CommandText = d.Source;
                                                Parameter(d, command);
                                                command.CommandType = CommandType.StoredProcedure;
                                            }
                                            using (myReader = await command.ExecuteReaderAsync())
                                            {
                                                //Retrieve column schema into a DataTable.
                                                schemaTable = myReader.GetSchemaTable();
                                                string? ColumnNameTemp;

                                                foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                                {
                                                    ColumnNameTemp = rowColumn[0].ToString();
                                                    //d.ColumnName.Add(ColumnNameTemp);
                                                    tabdetail.dbdashboard.ColumnName.Add(ColumnNameTemp);
                                                }
                                                var values = new List<Dictionary<string, object>>();

                                                while (myReader.Read())
                                                {
                                                    var fieldValues = new Dictionary<string, object>();
                                                    var temp = new List<dynamic>();
                                                    foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                                    {
                                                        ColumnNameTemp = rowColumn[0].ToString();
                                                        fieldValues.Add(ColumnNameTemp, myReader[ColumnNameTemp]);
                                                        temp.Add(myReader[ColumnNameTemp]);

                                                    }
                                                    values.Add(fieldValues);
                                                    //d.RowField.Add(temp);
                                                    tabdetail.dbdashboard.RowField.Add(temp);
                                                }
                                                listValues.Add(values);
                                            }
                                            countdatatable++;
                                        }
                                    }
                                }

                                finally
                                {

                                    connection.Close();
                                }

                                viewModel.Add(tabdetail);

                            }

                        }

                        // }
                    }

                }



                var MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                var Timer = MyConfig.GetValue<int>("RefreshPageTimer");
                ViewBag.Timer = Timer;
                string MediumViewNonGraph = HttpContext.Session.GetString("SessionMediumViewDisplayNonGraph");
                string LargeViewNonGraph = HttpContext.Session.GetString("SessionLargeViewDisplayNonGraph");
                string MediumViewGraph = HttpContext.Session.GetString("SessionMediumViewDisplayGraph");
                string LargeViewGraph = HttpContext.Session.GetString("SessionLargeViewDisplayGraph");


                ViewBag.MediumViewNonGraph = MediumViewNonGraph == "3" ? "4" : MediumViewNonGraph == "4" ? "3" : "4";
                ViewBag.LargeViewNonGraph = LargeViewNonGraph == "3" ? "4" : LargeViewNonGraph == "4" ? "3" : LargeViewNonGraph == "6" ? "2" : "2";
                ViewBag.MediumViewGraph = MediumViewGraph == "2" ? "6" : MediumViewGraph == "3" ? "4" : "4";
                ViewBag.LargeViewGraph = MediumViewGraph == "2" ? "6" : MediumViewGraph == "3" ? "4" : "4";
                ViewBag.Graph = JsonConvert.SerializeObject(lstgraph);
                ViewBag.Tables = JsonConvert.SerializeObject(listValues);
                //ViewData["DashboardName"] = new SelectList(viewModel, "DashboardName", "DashboardName");
                return _context.DashBoardDetails != null ?
                View(viewModel) :
                Problem("Entity set 'DashboardDbContext.DashboardModels'  is null.");
            }
        }



        public class Helper
        {
            public static string RenderRazorViewToString(Controller controller, string viewName, object model)
            {
                controller.ViewData.Model = model;
                using (var sw = new StringWriter())
                {
                    IViewEngine viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;
                    ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);

                    ViewContext viewContext = new ViewContext(
                        controller.ControllerContext,
                        viewResult.View,
                        controller.ViewData,
                        controller.TempData,
                        sw,
                        new HtmlHelperOptions()
                    );
                    viewResult.View.RenderAsync(viewContext);
                    return sw.GetStringBuilder().ToString();
                }
            }
        }

        [HttpPost]
        public IActionResult ShowSubHeader(string dashboardname)
        {
            var Dashboards = _dbdetailrepo.GetDashBoardDetailsByDashboardName(dashboardname).ToList();

            var viewModel = new List<DashBoardDetails>();

            if (Dashboards != null)
            {
                foreach (var d in Dashboards)
                {
                    if (d.Type.StartsWith("Table") && d.ArchiveFlag == "1")
                    {

                        String cs = @"Data Source=" + d.ServerName + ";Initial Catalog=" + d.DBName + ";Persist Security Info=True;User ID=" + d.LoginID + ";Password=" + d.Password;

                        using (SqlConnection connection = new SqlConnection(cs))
                        {

                            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
                            builder.ConnectionString = cs;
                            string server = builder.DataSource;
                            string database = builder.InitialCatalog;

                            try
                            {
                                if (connection.State != ConnectionState.Open)
                                {
                                    connection.Open();
                                    using (SqlCommand command = new SqlCommand("", connection))
                                    {
                                        DataTable schemaTable;
                                        SqlDataReader myReader;
                                        if (d.Type == "TableQuery")
                                        {
                                            command.CommandText = d.Notes;
                                        }
                                        else if (d.Type == "TableVw")
                                        {
                                            command.CommandText = @"SELECT * FROM " + d.Source;
                                        }
                                        else if (d.Type == "TableSp")
                                        {
                                            command.CommandText = d.Source;
                                            Parameter(d, command);
                                            command.CommandType = CommandType.StoredProcedure;
                                        }

                                        //command.Parameters.AddWithValue("@Name", model.Name);
                                        //command.ExecuteNonQuery();
                                        //myReader = command.ExecuteReader(CommandBehavior.KeyInfo);
                                        using (myReader = command.ExecuteReader())
                                        {
                                            //Retrieve column schema into a DataTable.
                                            schemaTable = myReader.GetSchemaTable();
                                            string? ColumnNameTemp;
                                            //d.ColumnName = new List<string>();
                                            //d.RowField = new List<dynamic>();

                                            foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                            {
                                                ColumnNameTemp = rowColumn[0].ToString();
                                                d.ColumnName.Add(ColumnNameTemp);

                                            }

                                            while (myReader.Read())
                                            {
                                                var temp = new List<dynamic>();
                                                foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                                {
                                                    ColumnNameTemp = rowColumn[0].ToString();
                                                    temp.Add(myReader[ColumnNameTemp]);

                                                }
                                                d.RowField.Add(temp);
                                            }
                                        }

                                    }
                                }
                            }

                            finally
                            {
                                connection.Close();
                            }

                            viewModel.Add(d);

                        }

                    }
                }
            }

            if (HttpContext.Session.GetString("SessionCustomerCode") == "ALL" || HttpContext.Session.GetString("SessionCustomerCode") == null || HttpContext.Session.GetString("SessionCustomerCode") == "")
            {
                ViewBag.Code = _dbdetailrepo.GetallDashboardDetails().Where(x => x.ArchiveFlag == "1").Select(c => new SelectListItem { Text = c.Code, Value = c.Code }).Distinct().ToList();
            }
            else
            {
                ViewBag.Code = _dbdetailrepo.GetallDashboardDetails().Where(x => x.ArchiveFlag == "1" && x.CustomerCode == HttpContext.Session.GetString("SessionCustomerCode")).Select(c => new SelectListItem { Text = c.Code, Value = c.Code }).Distinct().ToList();

            }

            var view1 = Helper.RenderRazorViewToString(this, "_SubHeaderPartial", Dashboards);
            var view2 = Helper.RenderRazorViewToString(this, "_TablePartial", viewModel);
            return Json(new { view1 = view1, view2 = view2 });

            //return PartialView("_SubHeaderPartial", dbdetails);

        }
        public void Parameter(DashBoardDetails item, SqlCommand cmd)
        {
            var strParameter = new List<string>();
            if (item.UDF01.Trim() != string.Empty)
            {
                strParameter.Add(item.UDF01);
            }
            if (item.UDF02.Trim() != string.Empty)
            {
                strParameter.Add(item.UDF02);
            }
            if (item.UDF03.Trim() != string.Empty)
            {
                strParameter.Add(item.UDF03);
            }
            if (item.UDF04.Trim() != string.Empty)
            {
                strParameter.Add(item.UDF04);
            }
            if (item.UDF05.Trim() != string.Empty)
            {
                strParameter.Add(item.UDF05);
            }

            if (strParameter != null)
            {
                foreach (string str in strParameter)
                {
                    var singleparameter = str.Split(',').ToList<string>();
                    foreach (string par in singleparameter)
                    {
                        var dataparam = par.Split('=').ToList<string>();
                        cmd.Parameters.AddWithValue(dataparam[0], dataparam[1]);

                    }
                }
            }



        }
        //[HttpPost]
        //public IActionResult ShowInformationBox(string dashboardname, string code, string customer, string city)
        //{
        //    var Dashboards = new List<DashBoardDetails>();
        //    var lstgraph = new List<GraphBox>();
        //    if (HttpContext.Session.GetString("SessionCustomerCode") == "ALL" || HttpContext.Session.GetString("SessionCustomerCode") == null || HttpContext.Session.GetString("SessionCustomerCode") == "")
        //    {
        //        Dashboards = _dbdetailrepo.GetDashBoardDetailsByCode(dashboardname, code).ToList();
        //    }
        //    else
        //    {
        //        Dashboards = _dbdetailrepo.GetDashBoardDetailsByCode(dashboardname, code).Where(x => x.CustomerCode == HttpContext.Session.GetString("SessionCustomerCode")).ToList();

        //    }

        //    var viewModel = new List<DashBoardDetails>();

        //    if (Dashboards != null)
        //    {
        //        foreach (var d in Dashboards)
        //        {
        //            if (d.Type == "Fixed")
        //            {
        //                //viewModel.Add(d);
        //            }
        //            else if (d.Type == "SP")
        //            {
        //                String cs = @"Data Source=" + d.ServerName + ";Initial Catalog=" + d.DBName + ";Persist Security Info=True;User ID=" + d.LoginID + ";Password=" + d.Password;
        //                using (SqlConnection connection = new SqlConnection(cs))
        //                {

        //                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //                    builder.ConnectionString = cs;
        //                    string server = builder.DataSource;
        //                    string database = builder.InitialCatalog;
        //                    DataTable schemaTable;
        //                    SqlDataReader myReader;
        //                    try
        //                    {
        //                        if (connection.State != ConnectionState.Open)
        //                        {
        //                            connection.Open();
        //                            using (SqlCommand command = new SqlCommand("", connection))
        //                            {

        //                                command.CommandText = d.Source;
        //                                //Parameter(d, command);
        //                                command.Parameters.AddWithValue("@BusinessPartyCode", customer);
        //                                command.Parameters.AddWithValue("@c_CityCode", city);
        //                                //command.Parameters.AddWithValue("@Name", model.Name);
        //                                command.CommandType = CommandType.StoredProcedure;

        //                                using (myReader = command.ExecuteReader())
        //                                {
        //                                    //Retrieve column schema into a DataTable.
        //                                    schemaTable = myReader.GetSchemaTable();
        //                                    string? ColumnNameTemp;
        //                                    while (myReader.Read())
        //                                    {
        //                                        foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
        //                                        {
        //                                            ColumnNameTemp = rowColumn[0].ToString();
        //                                            d.ListInformationBox.Add(new InformationBox(ColumnNameTemp, myReader[ColumnNameTemp].ToString()));

        //                                        }
        //                                    }
        //                                    d.Value = d.ListInformationBox.Count();
        //                                }

        //                                //  viewModel.Add(d);
        //                            }
        //                        }
        //                    }

        //                    finally
        //                    {
        //                        connection.Close();
        //                    }

        //                    if (d.GraphData != null && d.GraphData != "")
        //                    {
        //                        try
        //                        {
        //                            if (connection.State != ConnectionState.Open)
        //                            {
        //                                connection.Open();
        //                                using (SqlCommand command = new SqlCommand("", connection))
        //                                {

        //                                    command.CommandText = d.GraphData;
        //                                    //Parameter(d, command);
        //                                    command.Parameters.AddWithValue("@BusinessPartyCode", customer);
        //                                    command.Parameters.AddWithValue("@c_CityCode", city);
        //                                    command.CommandType = CommandType.StoredProcedure;

        //                                    using (myReader = command.ExecuteReader())
        //                                    {
        //                                        var xaxis = new List<string>();
        //                                        var legend = new List<string>();
        //                                        var lstvalue = new List<Array>();
        //                                        //Retrieve column schema into a DataTable.
        //                                        schemaTable = myReader.GetSchemaTable();
        //                                        string? ColumnNameTemp;

        //                                        for (int i = 0; i < myReader.FieldCount; i++)
        //                                        {
        //                                            if (i > 0)
        //                                            {
        //                                                xaxis.Add(myReader.GetName(i));
        //                                            }

        //                                        }
        //                                        while (myReader.Read())
        //                                        {
        //                                            int counter = 0;
        //                                            var value = new List<string>();
        //                                            foreach (DataRow rowColumn in schemaTable.Rows)
        //                                            {
        //                                                ColumnNameTemp = rowColumn[0].ToString();
        //                                                if (counter == 0)
        //                                                {
        //                                                    legend.Add(myReader[ColumnNameTemp].ToString());
        //                                                }
        //                                                else
        //                                                {
        //                                                    string str = myReader[ColumnNameTemp].ToString() == "" ? "0" : myReader[ColumnNameTemp].ToString();
        //                                                    value.Add(str);
        //                                                }

        //                                                counter++;
        //                                            }
        //                                            lstvalue.Add(value.ToArray());

        //                                        }
        //                                        GraphBox graph = new GraphBox(xaxis, legend, lstvalue);
        //                                        lstgraph.Add(graph);


        //                                    }

        //                                }
        //                            }
        //                        }

        //                        finally
        //                        {
        //                            connection.Close();
        //                        }
        //                    }

        //                }

        //            }
        //            else if (d.Type == "VW")
        //            {

        //                String cs = @"Data Source=" + d.ServerName + ";Initial Catalog=" + d.DBName + ";Persist Security Info=True;User ID=" + d.LoginID + ";Password=" + d.Password;
        //                using (SqlConnection connection = new SqlConnection(cs))
        //                {

        //                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //                    builder.ConnectionString = cs;
        //                    string server = builder.DataSource;
        //                    string database = builder.InitialCatalog;

        //                    try
        //                    {
        //                        if (connection.State != ConnectionState.Open)
        //                        {
        //                            connection.Open();
        //                            using (SqlCommand command = new SqlCommand("", connection))
        //                            {
        //                                //command.CommandText = @"SELECT * FROM " + d.Source;
        //                                //using (var result = command.ExecuteReader())
        //                                //{
        //                                //    DataTable dt = new DataTable();
        //                                //    dt.Load(result);
        //                                //    int numRows = dt.Rows.Count;
        //                                //    d.Value = numRows;
        //                                //    viewModel.Add(d);
        //                                //    //while (result.Read())
        //                                //    //{
        //                                //    //    //int total = Convert.ToInt32(result["Value"]);

        //                                //    //}

        //                                //}
        //                                command.CommandText = @"SELECT * FROM " + d.Source;
        //                                using (var myReader = command.ExecuteReader())
        //                                {
        //                                    //Retrieve column schema into a DataTable.
        //                                    var schemaTable = myReader.GetSchemaTable();
        //                                    string? ColumnNameTemp, ValueTemp;
        //                                    while (myReader.Read())
        //                                    {
        //                                        var tempLabel = new List<string>();
        //                                        var tempValue = new List<string>();
        //                                        foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
        //                                        {
        //                                            ColumnNameTemp = rowColumn[0].ToString();
        //                                            ValueTemp = myReader[ColumnNameTemp].ToString();
        //                                            InformationBox ibox = new InformationBox(ColumnNameTemp, ValueTemp);
        //                                            d.ListInformationBox.Add(ibox);
        //                                        }
        //                                    }
        //                                    d.Value = d.ListInformationBox.Count();
        //                                }
        //                                //viewModel.Add(d);
        //                            }
        //                        }
        //                    }
        //                    finally
        //                    {
        //                        connection.Close();
        //                    }
        //                }
        //            }
        //            viewModel.Add(d);
        //        }
        //    }

        //    ViewBag.Graph = JsonConvert.SerializeObject(lstgraph);
        //    string MediumViewNonGraph = HttpContext.Session.GetString("SessionMediumViewDisplayNonGraph");
        //    string LargeViewNonGraph = HttpContext.Session.GetString("SessionLargeViewDisplayNonGraph");
        //    string MediumViewGraph = HttpContext.Session.GetString("SessionMediumViewDisplayGraph");
        //    string LargeViewGraph = HttpContext.Session.GetString("SessionLargeViewDisplayGraph");


        //    ViewBag.MediumViewNonGraph = MediumViewNonGraph == "3" ? "4" : MediumViewNonGraph == "4" ? "3" : "4";
        //    ViewBag.LargeViewNonGraph = LargeViewNonGraph == "3" ? "4" : LargeViewNonGraph == "4" ? "3" : LargeViewNonGraph == "6" ? "2" : "2";
        //    ViewBag.MediumViewGraph = MediumViewGraph == "2" ? "6" : MediumViewGraph == "3" ? "4" : "4";
        //    ViewBag.LargeViewGraph = MediumViewGraph == "2" ? "6" : MediumViewGraph == "3" ? "4" : "4";

        //    var ViewNonGraph = Helper.RenderRazorViewToString(this, "_InformationBoxPartial", viewModel);
        //    var ViewGraph = Helper.RenderRazorViewToString(this, "_InformationBoxPartialWithGraph", viewModel);
        //    //return PartialView("_InformationBoxPartial", viewModel);
        //    return Json(new { ViewNonGraph, ViewGraph });
        //}


        [HttpPost]
        public IActionResult ShowInformationBox(string filter, string city, string tabcode)
        {
            int countdatagraph = 1;
            var viewModel = new List<TabDetail>();
            var tabuser = new List<TabDetail>();
            var Dashboards = new List<DashBoardDetails>();
            var lstgraph = new List<GraphBox>();
            if (HttpContext.Session.GetString("SessionCustomerCode") == "ALL" || HttpContext.Session.GetString("SessionCustomerCode") == null || HttpContext.Session.GetString("SessionCustomerCode") == "")
            {
                // Dashboards = _dbdetailrepo.GetDashBoardDetailsByCode(dashboardname, code).ToList();
            }
            else
            {
                tabuser = _context.TabDetails.Where(x => x.UserId == HttpContext.Session.GetString("SessionKeyUsername") && x.TabCode == Convert.ToInt32(tabcode)).OrderBy(x => x.DashBoardName).ThenBy(n => n.code2).ThenBy(n => n.Code).ToList();

                // Dashboards = _dbdetailrepo.GetDashBoardDetailsByCode(dashboardname, code).Where(x => x.CustomerCode == HttpContext.Session.GetString("SessionCustomerCode")).ToList();

            }

            foreach (var tabdetail in tabuser)
            {
                var d = new DashBoardDetails();
                d = _context.DashBoardDetails.Where(x => x.ArchiveFlag == "1" && x.DashBoardName == tabdetail.DashBoardName && x.Code == tabdetail.Code && x.code2 == tabdetail.code2 && x.CustomerCode == tabdetail.CustomerCode).SingleOrDefault();
                if (d != null)
                {
                    tabdetail.dbdashboard = d;

                    if (d.Type == "Fixed")
                    {
                        //viewModel.Add(tabdetail);
                    }
                    else if (d.Type == "SP")
                    {
                        String cs = @"Data Source=" + d.ServerName + ";Initial Catalog=" + d.DBName + ";Persist Security Info=True;User ID=" + d.LoginID + ";Password=" + d.Password;
                        using (SqlConnection connection = new SqlConnection(cs))
                        {

                            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                            builder.ConnectionString = cs;
                            string server = builder.DataSource;
                            string database = builder.InitialCatalog;
                            DataTable schemaTable;
                            SqlDataReader myReader;
                            try
                            {
                                if (connection.State != ConnectionState.Open)
                                {
                                    connection.Open();
                                    using (SqlCommand command = new SqlCommand("", connection))
                                    {

                                        command.CommandText = d.Source;
                                        //Parameter(d, command);
                                        if(!string.IsNullOrEmpty(d.SPParameter01))
                                        {
                                            command.Parameters.AddWithValue(d.SPParameter01, filter);
                                        }
                                        if (!string.IsNullOrEmpty(d.SPParameter02))
                                        {
                                            command.Parameters.AddWithValue(d.SPParameter02, city);
                                        }                                   
                                        //command.Parameters.AddWithValue("@Name", model.Name);
                                        command.CommandType = CommandType.StoredProcedure;

                                        using (myReader = command.ExecuteReader())
                                        {
                                            //Retrieve column schema into a DataTable.
                                            schemaTable = myReader.GetSchemaTable();
                                            string? ColumnNameTemp;
                                            while (myReader.Read())
                                            {
                                                foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                                {
                                                    ColumnNameTemp = rowColumn[0].ToString();
                                                    tabdetail.dbdashboard.ListInformationBox.Add(new InformationBox(ColumnNameTemp, myReader[ColumnNameTemp].ToString()));

                                                }
                                            }
                                            tabdetail.dbdashboard.Value = d.ListInformationBox.Count();
                                        }

                                        //  viewModel.Add(d);
                                    }
                                }
                            }

                            finally
                            {
                                connection.Close();
                            }

                            if (d.GraphData != null && d.GraphData != "")
                            {
                                d.dataCount = countdatagraph;
                                try
                                {
                                    if (connection.State != ConnectionState.Open)
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand("", connection))
                                        {

                                            command.CommandText = d.GraphData;
                                            //Parameter(d, command);
                                            if (!string.IsNullOrEmpty(d.SPParameter01))
                                            {
                                                command.Parameters.AddWithValue(d.SPParameter01, filter);
                                            }
                                            if (!string.IsNullOrEmpty(d.SPParameter02))
                                            {
                                                command.Parameters.AddWithValue(d.SPParameter02, city);
                                            }
                                            //command.Parameters.AddWithValue("@BusinessPartyCode", filter);
                                            //command.Parameters.AddWithValue("@c_CityCode", city);
                                            command.CommandType = CommandType.StoredProcedure;

                                            using (myReader = command.ExecuteReader())
                                            {
                                                var xaxis = new List<string>();
                                                var legend = new List<string>();
                                                var lstvalue = new List<Array>();
                                                //Retrieve column schema into a DataTable.
                                                schemaTable = myReader.GetSchemaTable();
                                                string? ColumnNameTemp;

                                                for (int i = 0; i < myReader.FieldCount; i++)
                                                {
                                                    if (i > 0)
                                                    {
                                                        xaxis.Add(myReader.GetName(i));
                                                    }

                                                }
                                                while (myReader.Read())
                                                {
                                                    int counter = 0;
                                                    var value = new List<string>();
                                                    foreach (DataRow rowColumn in schemaTable.Rows)
                                                    {
                                                        ColumnNameTemp = rowColumn[0].ToString();
                                                        if (counter == 0)
                                                        {
                                                            legend.Add(myReader[ColumnNameTemp].ToString());
                                                        }
                                                        else
                                                        {
                                                            string str = myReader[ColumnNameTemp].ToString() == "" ? "0" : myReader[ColumnNameTemp].ToString();
                                                            value.Add(str);
                                                        }

                                                        counter++;
                                                    }
                                                    lstvalue.Add(value.ToArray());

                                                }
                                                GraphBox graph = new GraphBox(xaxis, legend, lstvalue);
                                                lstgraph.Add(graph);


                                            }

                                        }
                                    }
                                }

                                finally
                                {
                                    connection.Close();
                                }
                                countdatagraph++;
                            }

                        }

                    }
                    else if (d.Type == "VW")
                    {

                        String cs = @"Data Source=" + d.ServerName + ";Initial Catalog=" + d.DBName + ";Persist Security Info=True;User ID=" + d.LoginID + ";Password=" + d.Password;
                        using (SqlConnection connection = new SqlConnection(cs))
                        {

                            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                            builder.ConnectionString = cs;
                            string server = builder.DataSource;
                            string database = builder.InitialCatalog;

                            try
                            {
                                if (connection.State != ConnectionState.Open)
                                {
                                    connection.Open();
                                    using (SqlCommand command = new SqlCommand("", connection))
                                    {
                                        //command.CommandText = @"SELECT * FROM " + d.Source;
                                        //using (var result = command.ExecuteReader())
                                        //{
                                        //    DataTable dt = new DataTable();
                                        //    dt.Load(result);
                                        //    int numRows = dt.Rows.Count;
                                        //    d.Value = numRows;
                                        //    viewModel.Add(d);
                                        //    //while (result.Read())
                                        //    //{
                                        //    //    //int total = Convert.ToInt32(result["Value"]);

                                        //    //}

                                        //}
                                        command.CommandText = @"SELECT * FROM " + d.Source;
                                        using (var myReader = command.ExecuteReader())
                                        {
                                            //Retrieve column schema into a DataTable.
                                            var schemaTable = myReader.GetSchemaTable();
                                            string? ColumnNameTemp, ValueTemp;
                                            while (myReader.Read())
                                            {
                                                var tempLabel = new List<string>();
                                                var tempValue = new List<string>();
                                                foreach (System.Data.DataRow rowColumn in schemaTable.Rows)
                                                {
                                                    ColumnNameTemp = rowColumn[0].ToString();
                                                    ValueTemp = myReader[ColumnNameTemp].ToString();
                                                    InformationBox ibox = new InformationBox(ColumnNameTemp, ValueTemp);
                                                    tabdetail.dbdashboard.ListInformationBox.Add(ibox);
                                                }
                                            }
                                            tabdetail.dbdashboard.Value = d.ListInformationBox.Count();
                                        }
                                        //viewModel.Add(d);
                                    }
                                }
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                    viewModel.Add(tabdetail);


                }
            }

           

            ViewBag.Graph = JsonConvert.SerializeObject(lstgraph);
            string MediumViewNonGraph = HttpContext.Session.GetString("SessionMediumViewDisplayNonGraph");
            string LargeViewNonGraph = HttpContext.Session.GetString("SessionLargeViewDisplayNonGraph");
            string MediumViewGraph = HttpContext.Session.GetString("SessionMediumViewDisplayGraph");
            string LargeViewGraph = HttpContext.Session.GetString("SessionLargeViewDisplayGraph");


            ViewBag.MediumViewNonGraph = MediumViewNonGraph == "3" ? "4" : MediumViewNonGraph == "4" ? "3" : "4";
            ViewBag.LargeViewNonGraph = LargeViewNonGraph == "3" ? "4" : LargeViewNonGraph == "4" ? "3" : LargeViewNonGraph == "6" ? "2" : "2";
            ViewBag.MediumViewGraph = MediumViewGraph == "2" ? "6" : MediumViewGraph == "3" ? "4" : "4";
            ViewBag.LargeViewGraph = MediumViewGraph == "2" ? "6" : MediumViewGraph == "3" ? "4" : "4";

            var ViewNonGraph = Helper.RenderRazorViewToString(this, "_InformationBoxPartial", viewModel);
            var ViewGraph = Helper.RenderRazorViewToString(this, "_InformationBoxPartialWithGraph", viewModel);
            //return PartialView("_InformationBoxPartial", viewModel);
            return Json(new { ViewNonGraph, ViewGraph });
        }
    }


}
