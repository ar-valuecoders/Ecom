using E_Com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Com.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsUI
        public ActionResult List()
        {
            EcomDatabaseEntities entities = new EcomDatabaseEntities();
            ViewBag.ProductCategies = entities.Categories.ToList();
            return View();
        }

        public ActionResult Detail(int productID)
        {
            EcomDatabaseEntities entities = new EcomDatabaseEntities();
           
            ViewBag.ProductCategies = entities.Products.SingleOrDefault(x => x.ProductID == productID);
            return View();
        }
    }
}