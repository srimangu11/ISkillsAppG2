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
        // GET: HomePage
        public ActionResult Index()
        {
           List<Categories> category = null;
            //Category c = new Category();
            try
            {
                ISkillsContext c = new ISkillsContext();
                // category = c.Categories.ToList();
                category = c.Categories.ToList();
            }catch(Exception e) { 
}
 
            return View(category);
        }
        //public ActionResult Details(int Id)
        //{
        //    Category c = new Category();
        //    Category category = c.Category.Single(cat => cat.CategoryId == Id);

        //}
    }
}