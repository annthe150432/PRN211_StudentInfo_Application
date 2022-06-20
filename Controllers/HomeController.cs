using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Project.Functions;
using Project.Models;
using System;
using System.Collections.Generic;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private FAP_ProjectContext db = new FAP_ProjectContext();
        public ActionResult Views()
        {
            try
            {
                var id = HttpContext.Session.GetInt32("user");
                return Home(id);
            }
            catch (Exception)
            {
                return View("Views/Index.cshtml");
            }
        }

        public ActionResult Home(int? id)
        {
            Login login = Function.getUserFromId((int)id);
            if (login==null) return View("Views/Index.cshtml");
            var view = View("Views/Home.cshtml");
            return view;
        }
        public ActionResult Login(string rollnumber, string raw_password)
        {
            string password = Function.HashPassword(raw_password);

            List<Login> userList = db.Logins.ToList<Login>().FindAll(l => l.RollNumber.Equals(rollnumber, StringComparison.InvariantCultureIgnoreCase));
            if (userList.Count<Login>()==0) return Views();
            var user = userList.First<Login>();
            if (Function.ValidatePassword(raw_password, user.Password))
            {
                HttpContext.Session.SetInt32("user", user.Id);
                if (user.Role == 0 || user.Role == 2) return Home(user.Id);
                else return Redirect("/Admin/AppList");
            }
            else
            {
                return Views();
            }
            
        }

        public RedirectResult Logout()
        {
            HttpContext.Session.Remove("user");
            return Redirect("/Home/Views");
        }

        public ActionResult Construction()
        {
            var view = View("Views/UnderConstruction.cshtml");
            return view;
        }
    }
}
