using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure;
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
            var cust = db.Customers.Where(c => c.Email == Details.Email).FirstOrDefault();
            if (cust == null)
            {
                db.Customers.Add(Details);
                db.SaveChanges();
            }
            else
            {
                //throw error
            }
            
            return View();


        }

    }
}