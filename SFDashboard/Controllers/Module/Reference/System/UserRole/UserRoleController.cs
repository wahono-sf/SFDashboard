using Microsoft.AspNetCore.Mvc;
using SFDashboard.SFModels;
using SFDashboard.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SFDashboard.Controllers.Module.Reference.System.UserRole
{
    public class UserRoleController : Controller
    {
        private readonly SFDbContext db;

        public UserRoleController(SFDbContext context)
        {
            db = context;
        }

        [Route("UserRole")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
