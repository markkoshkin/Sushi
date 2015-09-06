using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Statistic()
        {
            return View();
        }
    }
}
