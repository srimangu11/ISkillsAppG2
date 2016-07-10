using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISkillsMyApp.Models;

namespace ISkillsMyApp.Controllers
{
    public class HomePageController : Controller
    {
        ISkillsContext db = new ISkillsContext();

        // GET: HomePage
        public ActionResult Index()
        {
            var cat = db.Categories.ToList();
            return View(cat);
        }

        public PartialViewResult productPartial(int id)
        {
            var prod = db.Products.Where(p => p.CategoryID == id);
            return PartialView("_productPartial", prod);
        }
    }
}