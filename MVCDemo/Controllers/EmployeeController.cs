using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using MVCDemo.Migrations;
using static MVCDemo.Models.Employee;


namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {

        // GET: Employee

        public ActionResult Index()
        {
            using (EmployeeDataModel context = new EmployeeDataModel())
            {
                List<Employee> employess = context.Employees.ToList();

                //var employees = from e in context.Employees
                //                orderby e.ID
                //                select e;
                return View(employess);
            }
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                using (EmployeeDataModel context = new EmployeeDataModel())
                {
                    context.Employees.Add(emp);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            using (EmployeeDataModel context = new EmployeeDataModel())
            {
                var employee = context.Employees.Single(m => m.ID == id);
                return View(employee);
            }


        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                using (EmployeeDataModel context = new EmployeeDataModel())
                {
                    var employee = context.Employees.Single(m => m.ID == id);
                    if (TryUpdateModel(employee))
                    {
                        //To Do:- database code
                        context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    return View(employee);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Details/5
        //[OutputCache(Duration = int.MaxValue, VaryByParam = "id")]
        [OutputCache(CacheProfile = "Cache10Min")]
        public ActionResult Details(int id)
        {
            using (EmployeeDataModel context = new EmployeeDataModel())
            {
                var employee = context.Employees.SingleOrDefault(e => e.ID == id);
                return View(employee);
            }
        }
    }
}
