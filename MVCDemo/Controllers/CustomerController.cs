using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return Content(Server.HtmlEncode("Mohamed Gomaa"));
           // return View();
        }

        [OutputCache(Duration = 15)]
        public string GetAllCustomers()
        {
            return @"<ul>
            <li>Ali Raza</li>
            <li>Mark Upston</li>
            <li>Allan Bommer</li>
            <li>Greg Jerry</li>
            </ul>";
        }
    }
}