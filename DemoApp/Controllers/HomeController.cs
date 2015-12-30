using Common.Logging;
using DemoApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public IDemoService DemoService { get; set;  }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Depts()
        {
            ViewBag.Depts = DemoService.GetAllDepts();
            return View();
        }

        public ActionResult Emps(int deptNo = 0)
        {
            ViewBag.Emps = (deptNo == 0) ? DemoService.GetAllEmps() :  DemoService.GetEmpsByDeptNo(deptNo);
            return View();
        }
    }
}