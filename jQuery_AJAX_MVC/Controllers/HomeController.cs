using jQuery_AJAX_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery_AJAX_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("final1");
        }

        public ActionResult CC()
        {
            return View();
        }
        public ActionResult CC2()
        {
            return View();
        }
        public ActionResult CC3()
        {
            return View();

        }

        public ActionResult final()
        {
            return View();
        }

        public ActionResult final1()
        {
            return View();
        }



        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            PersonModel person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString()
            };
            return Json(person);
        }

        [HttpPost]
        public JsonResult AjaxPostCall(Employee employeeData)
        {
            Employee employee = new Employee
            {
                CCToken = employeeData.CCToken,
                ExpDate = employeeData.ExpDate,
                CCV = employeeData.CCV
            };
            return Json(employee, JsonRequestBehavior.AllowGet);
        }  
    }
}