using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SFDashboard.Models;
using SFDashboard.SFModels;
using System.Security.Cryptography;
using System.Text;

namespace SFDashboard.Controllers
{
    public class LoginController : Controller
    {
        SFDbContext ORM;
        DashboardDbContext SFORM;
        public LoginController(SFDbContext _ORM, DashboardDbContext _SFORM)
        {
            ORM = _ORM;
            SFORM = _SFORM;
        }

        public IActionResult Index()
        {
          
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Saus1 sf)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(sf.Password));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            UserAccessID userlogin = SFORM.UserAccessID.Where(x => x.UserId == sf.UserName && x.Password == sf.Password).FirstOrDefault();
            //Saus1 userlogin = ORM.Saus1s.Where(x => x.UserId == sf.UserName && x.Password == strBuilder.ToString()).FirstOrDefault();
            if (userlogin!=null)
            {
                if (userlogin.RoleId == 1)
                {
                    HttpContext.Session.SetString(SessionVariables.SessionKeyUsername, userlogin.UserId);
                    HttpContext.Session.SetString(SessionVariables.SessionCustomerCode, userlogin.CustomerCode);
                    HttpContext.Session.SetString(SessionVariables.SessionCompanyName, userlogin.CompanyName);
                    HttpContext.Session.SetString(SessionVariables.SessionMediumViewDisplayNonGraph, userlogin.MediumViewDisplayNonGraph == null ? "4" : userlogin.MediumViewDisplayNonGraph.ToString());
                    HttpContext.Session.SetString(SessionVariables.SessionLargeViewDisplayNonGraph, userlogin.LargeViewDisplayNonGraph == null ? "6" : userlogin.LargeViewDisplayNonGraph.ToString());
                    HttpContext.Session.SetString(SessionVariables.SessionMediumViewDisplayGraph, userlogin.MediumViewDisplayGraph == null ? "3" : userlogin.MediumViewDisplayGraph.ToString());
                    HttpContext.Session.SetString(SessionVariables.SessionLargeViewDisplayGraph, userlogin.LargeViewDisplayGraph == null ? "3" : userlogin.LargeViewDisplayGraph.ToString());
                    return RedirectToAction("Index", "Administrator");
                }
                else
                {
                    HttpContext.Session.SetString(SessionVariables.SessionKeyUsername, userlogin.UserId);
                    HttpContext.Session.SetString(SessionVariables.SessionCustomerCode, userlogin.CustomerCode);
                    HttpContext.Session.SetString(SessionVariables.SessionCompanyName, userlogin.CompanyName);
                    HttpContext.Session.SetString(SessionVariables.SessionMediumViewDisplayNonGraph, userlogin.MediumViewDisplayNonGraph == null ? "4" : userlogin.MediumViewDisplayNonGraph.ToString());
                    HttpContext.Session.SetString(SessionVariables.SessionLargeViewDisplayNonGraph, userlogin.LargeViewDisplayNonGraph == null ? "6" : userlogin.LargeViewDisplayNonGraph.ToString());
                    HttpContext.Session.SetString(SessionVariables.SessionMediumViewDisplayGraph, userlogin.MediumViewDisplayGraph == null ? "3" : userlogin.MediumViewDisplayGraph.ToString());
                    HttpContext.Session.SetString(SessionVariables.SessionLargeViewDisplayGraph, userlogin.LargeViewDisplayGraph == null ? "3" : userlogin.LargeViewDisplayGraph.ToString());
                    return RedirectToAction("Index", "DashboardModel");
                }
               
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Login was failed. Please Contact Your Support Team for Help.");
                return View("Index");
            }
        }
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionVariables.SessionKeyUsername);
            HttpContext.Session.Remove(SessionVariables.SessionCustomerCode);
            HttpContext.Session.Remove(SessionVariables.SessionMediumViewDisplayNonGraph);
            HttpContext.Session.Remove(SessionVariables.SessionLargeViewDisplayNonGraph);
            HttpContext.Session.Remove(SessionVariables.SessionMediumViewDisplayGraph);
            HttpContext.Session.Remove(SessionVariables.SessionLargeViewDisplayGraph);

            return RedirectToAction("Index", "Login");
        }
    }
}
