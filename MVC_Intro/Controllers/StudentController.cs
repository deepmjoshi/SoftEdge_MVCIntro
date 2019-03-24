using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Intro.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult List()
        {
            return View();
        }

        public ActionResult GetList()
        {
            return View();
        }
    }
}