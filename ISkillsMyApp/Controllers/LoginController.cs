using ISkillsMyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISkillsMyApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Customer c)
        {
            using (ISkillsContext Db = new ISkillsContext())
            {
                var v = Db.Customers.Where(x => x.Email.Equals(c.Email) && x.Password.Equals(c.Password)).FirstOrDefault();
                 if(v != null)
                {
                    Session["UserEmail"] = v.CustomerID.ToString();
                    Session["Password"] = v.FirstName;
                    return RedirectToAction("Index", "HomePage");

                }
                 else
                {
                    ViewBag.error = "Email or Password wrong";
                    return View();

                }
            }
        }
    }
}