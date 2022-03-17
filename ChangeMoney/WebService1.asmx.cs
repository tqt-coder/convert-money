using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ChangeMoney
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private const double USD_RATE = 22880.50;
        private const double EUR_RATE = 25254.92;


        [WebMethod]
        public double VNDToUSD(double money)
        {
            return money / USD_RATE;
        }

        [WebMethod]
        public double VNDToEUR(double money)
        {
            return money / EUR_RATE;
        }
        [WebMethod]
        public double USDToVND(double money)
        {
            return money*USD_RATE;
        }
        [WebMethod]
        public double EURToVND(double money)
        {
            return money * USD_RATE;

        }
       
      
    }
}
