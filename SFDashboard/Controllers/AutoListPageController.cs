using Microsoft.AspNetCore.Mvc;
using SFDashboard.SFModels;
using SFDashboard.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Xml;
using System.Reflection.PortableExecutable;
using System.Data.SqlClient;

namespace SFDashboard.Controllers
{

    public class AutoListPageController : Controller
    {

        private readonly SFDbContext db;
        private List<dynamic> entities = new List<dynamic>();

        public AutoListPageController(SFDbContext context)
        {
            db = context;
        }      

        [HttpGet]
        public IActionResult Index(string menuid)
        {
            //var a = new WrAppList();
            var Al = db.WrAppLists.Where(p => p.NodeName == menuid).SingleOrDefault();
            //var viewname = Type.GetType(Al.ViewName);           
            //GetValue<WrViewDefine>(Al.ViewName);
            //var results = db.Set<WrAppList> ().AsQueryable();
            //DbSet set = dbx.Set(typeof(a));

            using (var command = db.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "select * from " + Al.ViewName + " where 0=0 " + Al.ViewCondition;
                command.CommandType = CommandType.Text;

                db.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        entities.Add(result);
                    }
                }
            }

            if (Al.ViewCondition != null)
            {
                //results.Where();
            }

            ViewBag.Title = Al.CommentText;
            ViewBag.List = Al;
            ViewBag.KeyId = RemoveSquareBrackets(Al.ViewKey);
            return View(entities);
        }
        private String sqlDatoToJson(SqlDataReader dataReader)
        {
            var dataTable = new DataTable();
            dataTable.Load(dataReader);
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(dataTable);
            return JSONString;
        }

        public string RemoveSquareBrackets(string str)
        {
            str = str.Replace("[", "").Replace("]", "");
            return str;
        }
        public dynamic GetListPage(string menuid)
        {
            var values = new List<Dictionary<string, object>>();
            var Al = db.WrAppLists.Where(p => p.NodeName == menuid).SingleOrDefault();
            var vd = db.WrViewDefines.Where(e => e.ViewName == Al.ViewName).SingleOrDefault();

           
            using (var command = db.Database.GetDbConnection().CreateCommand())
            {
                string viewcontent;
                if (vd.ViewContent.Contains(Al.ViewKey))
                {
                     viewcontent = vd.ViewContent;
                }
                else
                {
                    viewcontent = Al.ViewKey + "," + vd.ViewContent;
                }
                command.CommandText = "select "+ viewcontent + " from " + Al.ViewName + " where 0=0 " + Al.ViewCondition;
                command.CommandType = CommandType.Text;                
                db.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {                    
                    while (result.Read())
                    {
                        // define the dictionary
                        var fieldValues = new Dictionary<string, object>();

                        // fill up each column and values on the dictionary                 
                        for (int i = 0; i < result.FieldCount; i++)
                        {               
                            fieldValues.Add(result.GetName(i), result[i]);
                        }
                        // add the dictionary on the values list
                        values.Add(fieldValues);

                    }
                }
            }

            return JsonConvert.SerializeObject(values);          
        }
    }
}
