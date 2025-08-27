using Microsoft.AspNetCore.Mvc;
using SFDashboard.SFModels;
using SFDashboard.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SFDashboard.Controllers.Module.Reference.System.MenuList
{

    public class MenuListController : Controller
    {
        private readonly SFDbContext db;

        public MenuListController(SFDbContext context)
        {
            db = context;
        }
        [Route("MenuList")]
        public IActionResult Index()
        {       
            return View();
        }

        public dynamic GetWrapplist(string nodename)
        {
            var mn = db.WrAppLists.ToList();

            var menus = db.WrAppLists.Where(x => x.NodeParent == null && x.NodeName == nodename).Single();
            var ListMenu = new List<WrAppList>();
            var jsonresult = Recursive(menus.NodeName, mn, ListMenu);
            return JsonConvert.SerializeObject(jsonresult);
        }
        [Route("MenuList/InsertMenu")]
        public dynamic InsertMenu(string values)
        {

            var mn = new WrAppList(); // Finding the item to be updated by key
            JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
            //if (!TryValidateModel(order))                           // Validating the updated item
            //    return new StatusCodeResult(BadRequestResult, ValidationErrorMessage);
            mn.UseFlag = UseFlagValue(mn);
            db.WrAppLists.Add(mn);
            db.SaveChanges();
            return Json(mn);
        }
        [Route("MenuList/UpdateMenu")]
        public dynamic UpdateMenu(string key, string values)
        {

            var mn = db.WrAppLists.First(o => o.NodeName == key);           
            // Finding the item to be updated by key
            JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values


            //mn.UseFlag = UseFlagValue(mn);
            db.WrAppLists.Update(mn);
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
        [Route("MenuList/DeleteMenu")]
        public dynamic DeleteMenu(string key)
        {
            var mn = db.WrAppLists.First(o => o.NodeName == key); // Finding the item to be updated by key
                                                                  //JsonConvert.PopulateObject(values, mn);              // Populating the found item with the changed values
                                                                  //if (!TryValidateModel(order))                           // Validating the updated item
                                                          //    return new StatusCodeResult(BadRequestResult, ValidationErrorMessage);
            db.WrAppLists.Remove(mn);
            db.SaveChanges();
            return Json(mn);
        }
        public string? UseFlagValue(WrAppList app)
        {
            string? flag;
            if (app.UseFlag == "true")
            {
                flag = "Y";
            }
            else if (app.UseFlag == "false")
            {
                flag = "N";
            }
            else
            {
                flag = null;
            }
            return flag;
        }
        public List<WrAppList> Recursive(string nodeparent, List<WrAppList> mn, List<WrAppList> s)
        {
            foreach (var subhead in mn.Where(a => a.NodeParent == nodeparent).OrderBy(a => a.SortNo))
            {
                //if (subhead.UseFlag == "Y" || subhead.UseFlag == null)
                //{
                //    subhead.UseFlag = "true";
                //}
                //else if (subhead.UseFlag == "N")
                //{
                //    subhead.UseFlag = "false";
                //}
                s.Add(subhead);
                Recursive(subhead.NodeName, mn, s);
            }
            return s;
        }
    }
}
