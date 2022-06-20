using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Project.Controllers
{
    public class ApplicationController : Controller
    {
        private FAP_ProjectContext db = new FAP_ProjectContext();
        private HomeController homeC = new HomeController();
        public ActionResult Views()
        {
            var view = View("Views/ViewApplication.cshtml");
            return view;
        }

        public ActionResult List()
        {
            try
            {
                var view = View("Views/ViewApplication.cshtml");
                var id = HttpContext.Session.GetInt32("user");
                Login log = db.Logins.ToList<Login>().FindAll(l => l.Id == id).First<Login>();
                var stuId = log.Student;
                List<Application> appls = db.Applications.ToList<Application>().FindAll(a => a.Student == stuId);
                ViewBag.appls = appls;
                return view;
            }
            catch (Exception)
            {
                return new RedirectResult("Home/Views");
            }
        }

        public ActionResult Create()
        {
            var id = HttpContext.Session.GetInt32("user");
            Login log = db.Logins.ToList<Login>().Find(l => l.Id == id);
            if (log == null) return Redirect("/Home/Views");
            var stuId = log.Student;
            Student student = db.Students.ToList<Student>().Find(l => l.Id == stuId);
            ViewData["finance"] = student.Financial;
            var view = View("Views/CreateApplication.cshtml");
            List<ApplicationType> types = db.ApplicationTypes.ToList<ApplicationType>();
            ViewBag.types = types;
            return view;
        }

        public FileResult Download(int appid)
        {
            try
            {
                Application appl = db.Applications.ToList<Application>().FindAll(a => a.Id == appid).First<Application>();
                byte[] fileBytes = System.IO.File.ReadAllBytes(@appl.File);
                string[] file = appl.File.Split(@"\");
                string fileName = file[file.Length - 1];
                return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        public RedirectResult AddApplication(int tid, string purpose, IFormFile file)
        {
            try
            {
                var id = HttpContext.Session.GetInt32("user");
                Login log = db.Logins.ToList<Login>().FindAll(l => l.Id == id).First<Login>();
                if (log == null) return Redirect("/Home/Views");
                var stuId = log.Student;
                Application appl = new Application();
                if (!(file is null))
                {
                    string[] extension = file.FileName.Split(@".");
                    string workingDirectory = @Environment.CurrentDirectory + @"\uploadFile";
                    string filename = @log.RollNumber
                        + @DateTime.UtcNow.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", @"")
                        + @"." + @extension[extension.Length - 1];
                    string path = Path.Combine(workingDirectory, filename);
                    FileStream stream = new FileStream(path, FileMode.Create);
                    file.CopyTo(stream);
                    appl.File = path;
                }
                appl.TypeId = tid;
                appl.Purpose = purpose;
                appl.Student = stuId;
                appl.CreatedDate = DateTime.Now;
                appl.UpdateDate = DateTime.Now;
                db.Add(appl);
                db.SaveChanges();
                return Redirect("/Application/Create");
            }
            catch (ArgumentNullException)
            {
                return Redirect("/Application/Create");
            }
            catch (IOException)
            {
                return Redirect("/Application/Create");
            }
        }
    }
}
