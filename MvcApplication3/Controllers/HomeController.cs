using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var context = new SushiTest1Entities();
            ViewBag.Product = context.Products;

            return View();
        }

        public ActionResult CategorySort()
        {
            var context = new SushiTest1Entities();
            List<Product> list = context.Products.ToList();
            List<Product> tempList = new List<Product>();

            for (int i = 0; i < list.Count; i++)
            {
                var d = list[i];
                if (d.CategoryId == 1)
                {
                    tempList.Add(d);
                }

            }

            ViewBag.Rol = tempList;
            return View();
        }

        public ActionResult CategorySortSup()
        {
            var context = new SushiTest1Entities();
            List<Product> list = context.Products.ToList();
            List<Product> tempList = new List<Product>();
            for (int i = 0; i < list.Count; i++)
            {
                var d = list[i];
                if (d.CategoryId == 4)
                {
                    tempList.Add(d);
                }
            }



            ViewBag.Rol = tempList;

            return View();
        }

    }
}
