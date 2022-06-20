using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Microsoft.AspNetCore.Http;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project.Controllers
{
    public class ProfileController : Controller
    {
        private FAP_ProjectContext db = new FAP_ProjectContext();
        public ActionResult Views()
        {
            try
            {
                var view = View("Views/ViewProfile.cshtml");
                var id = HttpContext.Session.GetInt32("user");
                Login log = db.Logins.ToList<Login>().Find(l => l.Id == id);
                if (log == null) return new RedirectResult("/Home/Views");
                var stuId = log.Student;
                Student student = db.Students.ToList<Student>().Find(s => s.Id == stuId);
                if (student.Dob != null)
                {
                    ViewBag.dob = ((DateTime)student.Dob).ToString("dd/MM/yyyy");
                }
                else
                {
                    ViewBag.dob = "";
                }
                if (student.Doi != null)
                {
                    ViewBag.doi = ((DateTime)student.Doi).ToString("dd/MM/yyyy");
                }
                else
                {
                    ViewBag.doi = "";
                }
                if (student.EnrollDate != null)
                {
                    ViewBag.enrolldate = ((DateTime)student.EnrollDate).ToString("dd/MM/yyyy");
                }
                else
                {
                    ViewBag.enrolldate = "";
                }
                ViewData["Login"] = log;
                ViewData["Student"] = student;
                view.ViewData.Model = student;
                return view;
            }
            catch (Exception)
            {
                return new RedirectResult("/Home/Views");
            }
        }

        public ActionResult Edit()
        {
            try
            {
                var view = View("Views/EditProfile.cshtml");
                var id = HttpContext.Session.GetInt32("user");
                Login log = db.Logins.ToList<Login>().FindAll(l => l.Id == id).First<Login>();
                if (log == null) return new RedirectResult("/Home/Views");
                var stuId = log.Student;
                Student student = db.Students.ToList<Student>().FindAll(s => s.Id == stuId).First<Student>();
                string address = "";
                var utf8 = Encoding.Unicode;
                if (student.Address != null)
                {
                    string[] fullAddress = student.Address.Split(",");
                    Province province = db.Provinces.ToList<Province>()
                        .FindAll(p => p.Name.Equals(fullAddress[^1].Trim(), StringComparison.InvariantCultureIgnoreCase))
                        .First<Province>();
                    City city = db.Cities.ToList<City>()
                        .FindAll(c => c.Name.Equals(fullAddress[^2].Trim(), StringComparison.InvariantCultureIgnoreCase))
                        .First<City>();
                    District district = db.Districts.ToList<District>()
                        .FindAll(d => d.Name.Equals(fullAddress[^3].Trim(), StringComparison.InvariantCultureIgnoreCase))
                        .First<District>();
                    
                    for (int i = 0; i < fullAddress.Length - 3; i++)
                    {
                        address += fullAddress[i];
                    }
                    List<Province> provinces = db.Provinces.ToList<Province>();
                    List<City> cities = db.Cities.ToList<City>().FindAll(c => (int)c.Province == province.Id);
                    List<District> districts = db.Districts.ToList<District>().FindAll(d => (int)d.City == city.Id);
                    MultiSelectList provinceSelect = new MultiSelectList(provinces, "Id", "Name", new int[] { province.Id });
                    MultiSelectList citySelect = new MultiSelectList(cities, "Id", "Name", new int[] { city.Id });
                    MultiSelectList districtSelect = new MultiSelectList(districts, "Id", "Name", new int[] { district.Id });
                    ViewBag.provinces = provinceSelect;
                    ViewBag.cities = citySelect;
                    ViewBag.districts = districtSelect;
                }
                else
                {
                    List<Province> provinces = db.Provinces.ToList<Province>();
                    List<City> cities = db.Cities.ToList<City>().FindAll(c => c.Province == 1);
                    List<District> districts = db.Districts.ToList<District>().FindAll(d => d.City == 1);
                    MultiSelectList provinceSelect = new MultiSelectList(provinces, "Id", "Name", new int[] { 1 });
                    MultiSelectList citySelect = new MultiSelectList(cities, "Id", "Name", new int[] { 1 });
                    MultiSelectList districtSelect = new MultiSelectList(districts, "Id", "Name", new int[] { 1 });
                    ViewBag.provinces = provinceSelect;
                    ViewBag.cities = citySelect;
                    ViewBag.districts = districtSelect;
                }
                List<Folk> folks = db.Folks.ToList<Folk>();
                List<Religion> religions = db.Religions.ToList<Religion>();
                MultiSelectList religionSelect;
                MultiSelectList folkSelect;
                if (student.Religion != null)
                {
                    religionSelect = new MultiSelectList(religions, "Id", "Name", new int[] { (int)student.Religion });
                }
                else
                {
                    religionSelect = new MultiSelectList(religions, "Id", "Name", new int[] { religions.First<Religion>().Id }); ;
                }
                if (student.Folk != null)
                {
                    folkSelect = new MultiSelectList(folks, "Id", "Name", new int[] { (int)student.Folk });
                }
                else
                {
                    folkSelect = new MultiSelectList(folks, "Id", "Name", new int[] { folks.First<Folk>().Id });
                }
                ViewBag.folks = folkSelect;
                ViewBag.religions = religionSelect;
                ViewBag.name = student.Fullname;
                ViewBag.phone = student.Phonenumber;
                if (student.Dob != null)
                {
                    ViewBag.dob = ((DateTime)student.Dob).ToString("yyyy-MM-dd");
                }
                else
                {
                    ViewBag.dob = DateTime.Now.ToString("yyyy-MM-dd");
                }
                if (student.Doi != null)
                {
                    ViewBag.doi = ((DateTime)student.Doi).ToString("yyyy-MM-dd");
                }
                else
                {
                    ViewBag.doi = DateTime.Now.ToString("yyyy-MM-dd");
                }
                ViewBag.id = student.Identity;
                ViewBag.poi = student.Poi;
                ViewBag.born = student.Born;
                ViewBag.gender = student.Gender;
                ViewBag.address = address;
                return view;
            }
            catch (Exception)
            {
                return new RedirectResult("/Home/Views");
            }
        }

        [HttpPost]
        public ActionResult ReloadCity(string fullname, DateTime dob, string phone, string id, DateTime doi, string poi,
            string born, string gender, int folks, int religions, int provinces, int cities, int districts, string address)
        {
            try
            {
                var uid = HttpContext.Session.GetInt32("user");
                Login log = db.Logins.ToList<Login>().FindAll(l => l.Id == uid).First<Login>();
                if (log == null) return new RedirectResult("/Home/Views");
                var view = View("Views/EditProfile.cshtml");
                List<Province> provincesList = db.Provinces.ToList<Province>();
                List<City> citiesList = db.Cities.ToList<City>().FindAll(c => (int)c.Province == provinces);
                List<District> districtsList = db.Districts.ToList<District>().FindAll(d => (int)d.City == citiesList.First<City>().Id);
                MultiSelectList provinceSelect = new MultiSelectList(provincesList, "Id", "Name", new int[] { provinces });
                MultiSelectList citySelect = new MultiSelectList(citiesList, "Id", "Name", new int[] { citiesList.First<City>().Id });
                MultiSelectList districtSelect = new MultiSelectList(districtsList, "Id", "Name", new int[] { districtsList.First<District>().Id });
                ViewBag.provinces = provinceSelect;
                ViewBag.cities = citySelect;
                ViewBag.districts = districtSelect;
                List<Folk> folksList = db.Folks.ToList<Folk>();
                List<Religion> religionsList = db.Religions.ToList<Religion>();
                MultiSelectList religionSelect;
                MultiSelectList folkSelect;
                religionSelect = new MultiSelectList(religionsList, "Id", "Name", new int[] { religions });
                
                folkSelect = new MultiSelectList(folksList, "Id", "Name", new int[] { folks });
                
                ViewBag.folks = folkSelect;
                ViewBag.religions = religionSelect;
                ViewBag.name = fullname;
                ViewBag.phone = phone;
                ViewBag.dob = dob.ToString("yyyy-MM-dd");
                ViewBag.doi = doi.ToString("yyyy-MM-dd");
                
                ViewBag.id = id;
                ViewBag.poi = poi;
                ViewBag.born = born;
                if (gender.Equals("male")) { ViewBag.gender = true; }
                else { ViewBag.gender = false; }
                ViewBag.address = address;
                return view;
            }
            catch (Exception)
            {
                return new RedirectResult("/Home/Views");
            }
        }

        [HttpPost]
        public ActionResult ReloadDistrict(string fullname, DateTime dob, string phone, string id, DateTime doi, string poi,
            string born, string gender, int folks, int religions, int provinces, int cities, int districts, string address)
        {
            try
            {
                var uid = HttpContext.Session.GetInt32("user");
                Login log = db.Logins.ToList<Login>().FindAll(l => l.Id == uid).First<Login>();
                if (log == null) return new RedirectResult("/Home/Views");
                var view = View("Views/EditProfile.cshtml");
                List<Province> provincesList = db.Provinces.ToList<Province>();
                List<City> citiesList = db.Cities.ToList<City>().FindAll(c => (int)c.Province == provinces);
                List<District> districtsList = db.Districts.ToList<District>().FindAll(d => (int)d.City == cities);
                MultiSelectList provinceSelect = new MultiSelectList(provincesList, "Id", "Name", new int[] { provinces });
                MultiSelectList citySelect = new MultiSelectList(citiesList, "Id", "Name", new int[] { cities });
                MultiSelectList districtSelect = new MultiSelectList(districtsList, "Id", "Name", new int[] { districtsList.First<District>().Id });
                ViewBag.provinces = provinceSelect;
                ViewBag.cities = citySelect;
                ViewBag.districts = districtSelect;
                List<Folk> folksList = db.Folks.ToList<Folk>();
                List<Religion> religionsList = db.Religions.ToList<Religion>();
                MultiSelectList religionSelect;
                MultiSelectList folkSelect;
                religionSelect = new MultiSelectList(religionsList, "Id", "Name", new int[] { religions });
                
                folkSelect = new MultiSelectList(folksList, "Id", "Name", new int[] { folks });
                
                ViewBag.folks = folkSelect;
                ViewBag.religions = religionSelect;
                ViewBag.name = fullname;
                ViewBag.phone = phone;
                ViewBag.dob = dob.ToString("yyyy-MM-dd");
                ViewBag.doi = doi.ToString("yyyy-MM-dd");
                
                ViewBag.id = id;
                ViewBag.poi = poi;
                ViewBag.born = born;
                if (gender.Equals("male")) { ViewBag.gender = true; }
                else { ViewBag.gender = false; }
                ViewBag.address = address;
                return view;
            }
            catch (Exception)
            {
                return new RedirectResult("/Home/Views");
            }
        }

        [HttpPost]
        public RedirectResult EditProfile(string fullname, DateTime dob, string phone, string id, DateTime doi, string poi,
            string born, string gender, int folks, int religions, int provinces, int cities, int districts, string address)
        {
            try
            {
                var uid = HttpContext.Session.GetInt32("user");
                Login log = db.Logins.ToList<Login>().FindAll(l => l.Id == uid).First<Login>();
                if (log == null) return new RedirectResult("/Home/Views");
                Province province = db.Provinces.ToList<Province>().Find(p => p.Id == provinces);
                City city = db.Cities.ToList<City>().Find(c => c.Id == cities);
                District district = db.Districts.ToList<District>().Find(d => d.Id == districts);
                var stuId = log.Student;
                Student student = db.Students.ToList<Student>().Find(s => s.Id == stuId);
                if (student == null) return Redirect("/Home/Views");
                student.Fullname = fullname;
                student.Dob = dob;
                student.Phonenumber = phone;
                student.Identity = id;
                student.Doi = doi;
                student.Poi = poi;
                student.Born = born;
                if (gender.Equals("male"))
                {
                    student.Gender = true;
                }
                else
                {
                    student.Gender = false;
                }

                student.Folk = folks;
                student.Religion = religions;
                student.Address = address + "," + district.Name + "," + city.Name + "," + province.Name;
                db.SaveChanges();
                return Redirect("/Profile/Edit");
            }
            catch
            {
                return Redirect("/Home/Views");
            }
        }

    }
}
