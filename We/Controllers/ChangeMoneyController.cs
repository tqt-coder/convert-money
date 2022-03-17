using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace We.Controllers
{
    public class ChangeMoneyController : Controller
    {
        // GET: ChangeMoney
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChangeMoney/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChangeMoney/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChangeMoney/Create
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            using (ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient())
            {

                try
                {
                    string number = form["inputMoney"].ToString();
                    string typeMoney = form["typeMoney"].ToString();

                    if (number != null && typeMoney != null)
                    {
                        double tempt = Convert.ToDouble(number);
                        double result = 0;
                        switch (typeMoney)
                        {
                            case "VND2USD":
                                result = ws.VNDToUSD(tempt);
                                break;
                            case "VND2EUR":
                                result = ws.VNDToEUR(tempt);
                                break;
                            case "USD2VND":
                                result = ws.USDToVND(tempt);
                                break;
                            case "EUR2VND":
                                result = ws.EURToVND(tempt);
                                break;
                        }
                        TempData["number"] = tempt;
                        TempData["result"] = Math.Round(result, 3);
                    }

                    return RedirectToAction("Index", "Home");
                }
                catch
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }




    }
}
