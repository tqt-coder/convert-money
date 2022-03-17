using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace We.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (TempData["result"] != null && TempData["number"] != null)
            {
                ViewBag.Result = TempData["result"].ToString();
                ViewBag.Number = TempData["number"].ToString();
            }
            return View();
        }

       
    }
}