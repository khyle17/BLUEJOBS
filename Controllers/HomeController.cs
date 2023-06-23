using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLUEJOB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult GettingStarted()
        {
            return View();
        }
        public ActionResult SKLogin()
        {
            return View();
        }
        public ActionResult SKLogin1()
        {
            return View();
        }
        public ActionResult SSLogin()
        {
            return View();
        }
        public ActionResult SSLogin0() 
        {
            return View();
        }
        public ActionResult IALogin()
        {
            return View();
        }
        public ActionResult BLogin()
        {
            return View();
        }
        public ActionResult SKReg()
        {
            return View();
        }
        public ActionResult SSReg()
        {
            return View();
        }
        public ActionResult IAReg()
        {
            return View();
        }
        public ActionResult IAReg1() 
        {
            return View();  
        }
        public ActionResult BReg() 
        {
            return View();
        }
        public ActionResult BReg1() 
        {
            return View();
        }
        public ActionResult BReg2()
        {
            return View();
        }
        public ActionResult SKDash()
        {
            return View();
        }
        public ActionResult SSDash()
        {
            return View();
        }
        public ActionResult IADash()
        {
            return View();
        }
        public ActionResult BDash()
        {
            return View();
        }

    }
}