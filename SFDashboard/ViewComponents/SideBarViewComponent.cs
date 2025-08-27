using Microsoft.AspNetCore.Mvc;
using SFDashboard.SFModels;
using SFDashboard.Models;
using System.Threading.Tasks;


namespace SFDashboard.ViewComponents
{
    [ViewComponent(Name = "SideBar")]
    public class SideBarViewComponent : ViewComponent
    {
        private readonly SFDbContext db;
        public SideBarViewComponent(SFDbContext context)
        {          
            db = context;         
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string userid = HttpContext.Session.GetString(SessionVariables.SessionKeyUsername);
            var menus = db.VwUserMenus.Where(x => x.UserId == userid).ToList();
            return View("Index", menus);
        }
    }
}
