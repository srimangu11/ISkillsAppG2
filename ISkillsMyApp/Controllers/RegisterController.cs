using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Web;
using PagedList;
using System.Web.Mvc;
using ISkillsMyApp.Models;

namespace ISkillsMyApp.Controllers
{
    public class RegisterController : Controller
    {
        public Customer Details { get; private set; }

        // GET: Register
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer Details)
        {
            ISkillsContext db = new ISkillsContext();
            db.Customers.Add(Details);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult view()
        {
            return View();
        }
        [HttpPost]

        public ActionResult View(Customer Details)
        {
            ISkillsContext db = new ISkillsContext();
            db.Customers.Add(Details);
            db.SaveChanges();
            return View();
        }

    }
}