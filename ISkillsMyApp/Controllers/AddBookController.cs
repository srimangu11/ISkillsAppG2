using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ISkillsMyApp.Models;
using System.Web.Mvc;

namespace ISkillsMyApp.Controllers
{
    public class AddBookController : Controller
    {
        //public Product Details { get; private set; }
        // GET: AddBook
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Product Details)
        {
            ISkillsContext db = new ISkillsContext();
            db.Products.Add(Details);
            db.SaveChanges();
            return View();

        }
    }
}