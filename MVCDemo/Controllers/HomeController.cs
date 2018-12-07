using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Filters;

namespace MVCDemo.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult GoToCustomersPage()
        {
            return RedirectToAction("GetAllCustomers", "Customer");
        }

        #region Selectors

        /// <summary>
        /// 
        /// There are three types of action selector attributes −

        ///  ActionName
        ///  NonAction
        ///  ActionVerbs
        /// </summary>
        /// <returns></returns>

        [ActionName("CurrentTime")]
        [OutputCache(Duration = 20)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }

        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString("T");
        }

        /*
         MVC framework supports the following ActionVerbs:
            HttpGet
            HttpPost
            HttpPut
            HttpDelete
            HttpOptions
            HttpPatch
         */
        #endregion

        public ActionResult MyView()
        {
            return View();
        }
    }
}