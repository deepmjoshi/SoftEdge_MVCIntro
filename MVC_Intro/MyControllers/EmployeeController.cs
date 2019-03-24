using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intro.MyControllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string paramList)
        {
            return View();
        }
    }
}