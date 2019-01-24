using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories()
        {
            var category = new List<Categories>();
            Categories categories = new Categories();
            categories.Food = "Food";
            categories.Tech = "Tech";
            categories.Sports = "Sports";
            category.Add(categories);

            return View(categories);
        }

        public ActionResult Details(String CategoriesName)
        {
            ViewBag.CategoriesName = "You Selected Category:" +CategoriesName;
            return View();
        }

        
    }
}