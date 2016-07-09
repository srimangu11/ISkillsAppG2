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
            ISkillsContext c = new ISkillsContext();
            List<Categories> category = c.Categories.ToList();

            return View(category);
        }
        public ActionResult ProductView(int id)
        {
            ISkillsContext c = new ISkillsContext();
            IEnumerable<Product> product = c.Products.Where(x => x.CategoryID == id);
            return View(product);
        }
        }
    }
