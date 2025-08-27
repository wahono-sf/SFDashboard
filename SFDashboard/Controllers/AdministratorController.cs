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
using static SFDashboard.Controllers.DashboardModelController;

namespace SFDashboard.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly DashboardDbContext db;
        private readonly DashboardDbContext _context;
        private readonly SFDbContext _sfcontext;
        private readonly IDashBoardDetailsRepository _dbdetailrepo;

        public AdministratorController(DashboardDbContext context, SFDbContext context2, IDashBoardDetailsRepository dbdetailrepo)
        {
            db = context;
            _context = context;
            _sfcontext = context2;
            _dbdetailrepo = dbdetailrepo;
        }
        public async Task<IActionResult> Index()
        {

            if (HttpContext.Session.GetString("SessionKeyUsername") == null || HttpContext.Session.GetString("SessionKeyUsername") == "")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {

                var Dashboards = new List<DashBoardDetails>();
                var listValues = new List<object>();
                var lstgraph = new List<GraphBox>();
                var viewModel = new List<DashBoardDetails>();
                if (HttpContext.Session.GetString("SessionCustomerCode") == "ALL" || HttpContext.Session.GetString("SessionCustomerCode") == null || HttpContext.Session.GetString("SessionCustomerCode") == "")
                {
                    Dashboards = _context.DashBoardDetails.Where(x => x.ArchiveFlag == "1").ToList();
                }
                else
                {
                    Dashboards = _context.DashBoardDetails.Where(x => x.ArchiveFlag == "1" && x.CustomerCode == HttpContext.Session.GetString("SessionCustomerCode")).ToList();

                }
                if (Dashboards != null)
                {
                    foreach (var d in Dashboards)
                    {

                        if (d.Type == "Fixed")
                        {
                            //viewModel.Add(new DashBoardDetails { DashBoardName = d.DashBoardName, code2 = d.code2, LabelName = d.LabelName, Value = d.Value });
                            viewModel.Add(d);
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
                                            //command.Parameters.AddWithValue("@BusinessPartyCode", "ALL");
                                            //command.Parameters.AddWithValue("@c_CityCode", "ALL");

                                            //command.Parameters.AddWithValue("@Name", model.Name);                                       
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
                                                        d.ListInformationBox.Add(new InformationBox(ColumnNameTemp, myReader[ColumnNameTemp].ToString()));

                                                    }
                                                }
                                                d.Value = d.ListInformationBox.Count();
                                            }
                                            //int total = Convert.ToInt32(command.ExecuteScalar());
                                            //d.Value = total;
                                            viewModel.Add(d);
                                        }
                                    }
                                }

                                finally
                                {
                                    connection.Close();
                                }
                                if (d.GraphData != null && d.GraphData != "")
                                {
                                    try
                                    {
                                        if (connection.State != ConnectionState.Open)
                                        {
                                            connection.Open();
                                            using (SqlCommand command = new SqlCommand("", connection))
                                            {

                                                command.CommandText = d.GraphData;
                                                Parameter(d, command);
                                                //command.Parameters.AddWithValue("@BusinessPartyCode", "ALL");
                                                //command.Parameters.AddWithValue("@c_CityCode", "ALL");
                                                //command.Parameters.AddWithValue("@Name", model.Name);                                       
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
                                                            // d.ListGraphBox.Add(new GraphBox(ColumnNameTemp, myReader[ColumnNameTemp].ToString()));
                                                            counter++;
                                                        }
                                                        lstvalue.Add(value.ToArray());
                                                        //d.ListGraphBox.Add(new GraphBox(xaxis, legend,value))
                                                    }
                                                    GraphBox graph = new GraphBox(xaxis, legend, lstvalue);
                                                    lstgraph.Add(graph);

                                                    // d.Value = d.ListInformationBox.Count();
                                                }
                                                //int total = Convert.ToInt32(command.ExecuteScalar());
                                                //d.Value = total;

                                                //viewModel.Add(d);
                                            }
                                        }
                                    }

                                    finally
                                    {
                                        connection.Close();
                                    }
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

                                try
                                {
                                    if (connection.State != ConnectionState.Open)
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand("", connection))
                                        {

                                            command.CommandText = @"sp_GetCustomerDashboard";
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
                                                ViewBag.BusinessParty = values;
                                            }

                                            // viewModel.Add(d);
                                        }
                                    }
                                }
                                finally
                                {
                                    connection.Close();
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
                                                        d.ListInformationBox.Add(ibox);
                                                    }
                                                }
                                                d.Value = d.ListInformationBox.Count();
                                            }
                                            viewModel.Add(d);
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
                                                    d.ColumnName.Add(ColumnNameTemp);

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
                                                    d.RowField.Add(temp);
                                                }
                                                listValues.Add(values);
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

        public void Parameter(DashBoardDetails item, SqlCommand cmd)
        {
            var strParameter = new List<string>();
            if (!string.IsNullOrWhiteSpace(item.UDF01))
            {
                strParameter.Add(item.UDF01);
            }
            if (!string.IsNullOrWhiteSpace(item.UDF02))
            {
                strParameter.Add(item.UDF02);
            }
            if (!string.IsNullOrWhiteSpace(item.UDF03))
            {
                strParameter.Add(item.UDF03);
            }
            if (!string.IsNullOrWhiteSpace(item.UDF04))
            {
                strParameter.Add(item.UDF04);
            }
            if (!string.IsNullOrWhiteSpace(item.UDF05))
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
        [HttpPost]
        public IActionResult ShowInformationBox(string dashboardname, string code, string customer, string city)
        {
            var Dashboards = new List<DashBoardDetails>();
            var lstgraph = new List<GraphBox>();
            if (HttpContext.Session.GetString("SessionCustomerCode") == "ALL" || HttpContext.Session.GetString("SessionCustomerCode") == null || HttpContext.Session.GetString("SessionCustomerCode") == "")
            {
                Dashboards = _dbdetailrepo.GetDashBoardDetailsByCode(dashboardname, code).ToList();
            }
            else
            {
                Dashboards = _dbdetailrepo.GetDashBoardDetailsByCode(dashboardname, code).Where(x => x.CustomerCode == HttpContext.Session.GetString("SessionCustomerCode")).ToList();

            }

            var viewModel = new List<DashBoardDetails>();

            if (Dashboards != null)
            {
                foreach (var d in Dashboards)
                {
                    if (d.Type == "Fixed")
                    {
                        //viewModel.Add(d);
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
                                        command.Parameters.AddWithValue("@BusinessPartyCode", customer);
                                        command.Parameters.AddWithValue("@c_CityCode", city);
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
                                                    d.ListInformationBox.Add(new InformationBox(ColumnNameTemp, myReader[ColumnNameTemp].ToString()));

                                                }
                                            }
                                            d.Value = d.ListInformationBox.Count();
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
                                try
                                {
                                    if (connection.State != ConnectionState.Open)
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand("", connection))
                                        {

                                            command.CommandText = d.GraphData;
                                            //Parameter(d, command);
                                            command.Parameters.AddWithValue("@BusinessPartyCode", customer);
                                            command.Parameters.AddWithValue("@c_CityCode", city);
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
                                                    d.ListInformationBox.Add(ibox);
                                                }
                                            }
                                            d.Value = d.ListInformationBox.Count();
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
                    viewModel.Add(d);
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

        public dynamic GetUserAccessID()
        {
            var user = db.UserAccessID.ToList();          
            return JsonConvert.SerializeObject(user);
        }

        public dynamic GetTabDetails()
        {
            var user = db.TabDetails.ToList();
            return JsonConvert.SerializeObject(user);
        }
        public dynamic GetDashboardDetails()
        {
            var dashboarddetails = db.DashBoardDetails.ToList();
            return JsonConvert.SerializeObject(dashboarddetails);
        }


      
        public dynamic InsertUserAccessID(string values)
        {

            var mn = new UserAccessID(); // Finding the item to be updated by key
            JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
                                                                 //if (!TryValidateModel(order))                           // Validating the updated item
                                                                 //    return new StatusCodeResult(BadRequestResult, ValidationErrorMessage);
            if(mn.RoleId==null)
            {
                mn.RoleId = 1;
            }
            mn.CreateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.CreateDateTime =DateTime.Now;
            mn.UpdateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.UpdateDateTime = DateTime.Now;
            mn.StatusCode = "USE";
            db.UserAccessID.Add(mn);
            db.SaveChanges();
            return Json(mn);
        }
       
        public dynamic UpdateUserAccessID(string key, string values)
        {

            var mn = db.UserAccessID.First(o => o.UserId == key);
            // Finding the item to be updated by key
            JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
            mn.CreateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.CreateDateTime = DateTime.Now;
            mn.UpdateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.UpdateDateTime = DateTime.Now;
            db.UserAccessID.Update(mn);
            db.SaveChanges();

            //if (mn.UseFlag == "Y" || mn.UseFlag == null)
            //{
            //    mn.UseFlag = "true";
            //}
            //else if (mn.UseFlag == "N")
            //{
            //    mn.UseFlag = "false";
            //}

            return Json(mn);
        }
       
        public dynamic DeleteUserAccessID(string key)
        {
            var mn = db.UserAccessID.First(o => o.UserId == key); // Finding the item to be updated by key
                                                                  //JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
                                                                  //if (!TryValidateModel(order))                           // Validating the updated item
                                                                  //    return new StatusCodeResult(BadRequestResult, ValidationErrorMessage);

            mn.CreateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.CreateDateTime = DateTime.Now;
            mn.UpdateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.UpdateDateTime = DateTime.Now;
            mn.StatusCode = "DEL";
            db.UserAccessID.Update(mn);
           
           // db.UserAccessID.Remove(mn);
            db.SaveChanges();
            return Json(mn);
        }

        public dynamic InsertTabDetails(string values)
        {

            var mn = new TabDetail(); // Finding the item to be updated by key
            JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
                                                                 //if (!TryValidateModel(order))                           // Validating the updated item
                                                                 //    return new StatusCodeResult(BadRequestResult, ValidationErrorMessage);
            if (mn.TabCode == null)
            {
                mn.TabCode = 1;
            }
            
            db.TabDetails.Add(mn);
            db.SaveChanges();
            return Json(mn);
        }

        public dynamic UpdateTabDetails(string key, string values)
        {
            var details = new TabDetail();

            // Finding the item to be updated by key
            JsonConvert.PopulateObject(key, details);              // Populating the found item with the changed values

            var mn = db.TabDetails.First(o => o.DashBoardName == details.DashBoardName && o.Code == details.Code && o.code2 == details.code2 && o.CustomerCode == details.CustomerCode && o.UserId == details.UserId && o.TabCode == details.TabCode);
            db.TabDetails.Remove(mn);
            db.SaveChanges();
            JsonConvert.PopulateObject(values, mn);
            db.TabDetails.Add(mn);
            db.SaveChanges();

            return Json(mn);
        }


        public dynamic DeleteTabDetails(string key)
        {
            var details = new TabDetail();

            // Finding the item to be updated by key
            JsonConvert.PopulateObject(key, details);              // Populating the found item with the changed values

            var mn = db.TabDetails.First(o => o.DashBoardName == details.DashBoardName && o.Code == details.Code && o.code2 == details.code2 && o.CustomerCode == details.CustomerCode && o.UserId == details.UserId && o.TabCode == details.TabCode);

                                                                             // Finding the item to be updated by key
                                                                             //JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
                                                                             //if (!TryValidateModel(order))                           // Validating the updated item
                                                                             //    return new StatusCodeResult(BadRequestResult, ValidationErrorMessage);
            db.TabDetails.Remove(mn);
            db.SaveChanges();
            return Json(mn);
        }


        public dynamic InsertDashboardDetails(string values)
        {

            var mn = new DashBoardDetails(); // Finding the item to be updated by key
            JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
                                                                 //if (!TryValidateModel(order))                           // Validating the updated item
                                                                 //    return new StatusCodeResult(BadRequestResult, ValidationErrorMessage);

            mn.CreateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.CreateDateTime = DateTime.Now;
            mn.UpdateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.UpdateDateTime = DateTime.Now;
           
            db.DashBoardDetails.Add(mn);
            db.SaveChanges();
            return Json(mn);
        }

        public dynamic UpdateDashboardDetails(string key, string values)
        {
            var details = new DashBoardDetails();
          
            // Finding the item to be updated by key
            JsonConvert.PopulateObject(key, details);              // Populating the found item with the changed values

            var mn = db.DashBoardDetails.First(o => o.DashBoardName == details.DashBoardName && o.Code==details.Code && o.code2 == details.code2 && o.CustomerCode == details.CustomerCode);
            JsonConvert.PopulateObject(values, mn);
            mn.CreateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.CreateDateTime = DateTime.Now;
            mn.UpdateBy = HttpContext.Session.GetString("SessionKeyUsername");
            mn.UpdateDateTime = DateTime.Now;

            //mn.UseFlag = UseFlagValue(mn);
            db.DashBoardDetails.Update(mn);
            db.SaveChanges();

            //if (mn.UseFlag == "Y" || mn.UseFlag == null)
            //{
            //    mn.UseFlag = "true";
            //}
            //else if (mn.UseFlag == "N")
            //{
            //    mn.UseFlag = "false";
            //}

            return Json(mn);
        }

        public dynamic DeleteDashboardDetails(string key)
        {
            var mn = db.DashBoardDetails.First(o => o.DashBoardName == key); // Finding the item to be updated by key
                                                                  //JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
                                                                  //if (!TryValidateModel(order))                           // Validating the updated item
                                                                  //    return new StatusCodeResult(BadRequestResult, ValidationErrorMessage);
            db.DashBoardDetails.Remove(mn);
            db.SaveChanges();
            return Json(mn);
        }


    }
}
