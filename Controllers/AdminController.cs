using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Project.Functions;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Project.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private FAP_ProjectContext db = new FAP_ProjectContext();
        public ActionResult CreateStudentAccount()
        {
            var id = HttpContext.Session.GetInt32("user");
            List<Login> logList = db.Logins.ToList<Login>().FindAll(l => l.Id == id);
            if (logList.Count<Login>() == 0) return Redirect("/Home/Views");
            Login log = logList.First<Login>();
            if (log == null) return Redirect("/Home/Views");
            if (log.Role != 3) return Redirect("/Home/Views");
            if (log.Staff == null) return Redirect("/Home/Views");
            Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\avatar\\");
            var fullPathName = _hostingEnvironment.WebRootPath + "\\avatar\\";
            Student student = new Student();
            student.Fullname = "Nguyễn Thu An";
            student.Gender = true;
            student.Email = "AnNTHE150432@fpt.edu.vn";
            db.Add(student);
            db.SaveChanges();
            Login login = new Login();
            login.Student = db.Students.ToList<Student>()
                .FindAll(s => s.Email.Equals(student.Email, StringComparison.InvariantCultureIgnoreCase)).First<Student>().Id;
            login.RollNumber = "AnNTHE150432";
            login.Password = Function.HashPassword("123456");
            db.Add(login);
            db.SaveChanges();
            return Redirect("/Home/Views");
        }

        public ActionResult AppList()
        {
            var id = HttpContext.Session.GetInt32("user");
            Login log = db.Logins.ToList<Login>().Find(l => l.Id == id);
            if (log == null) return Redirect("/Home/Views");
            if ((int)log.Role != 3) return Redirect("/Home/Views");
            if (log.Staff == null) return Redirect("/Home/Views");
            var view = View("Views/Admin/ShowApplication.cshtml");
            List<Application> appls = db.Applications.ToList<Application>();
            foreach(var item in appls)
            {
                Student student = db.Students.ToList<Student>().FindAll(s => s.Id == item.Student).First<Student>();
                item.StudentNavigation = student;
            }
            ViewBag.appls = appls;
            return view;
        }
        public RedirectResult Decide(int id, int status, string note)
        {
            var uid = HttpContext.Session.GetInt32("user");
            Login log = db.Logins.ToList<Login>().FindAll(l => l.Id == uid).First<Login>();
            if (log == null) return Redirect("/Home/Views");
            if (log.Role != 3) return Redirect("/Home/Views");
            if (log.Staff == null) return Redirect("/Home/Views");
            Application appl = db.Applications.ToList<Application>().Find(a => a.Id == id);
            if (appl == null) return Redirect("/Home/Views");
            appl.Status = status;
            appl.UpdateDate = DateTime.Now;
            appl.Note = note;
            db.SaveChanges();
            return Redirect("/Admin/AppList");
        }
    }
}
