﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees_Mangement_System.Controllers
{
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

        public ActionResult Payroll()
        {
            ViewBag.Message = "Your Payroll page.";

            return View();
        }
        public ActionResult Departements()
        {
            ViewBag.Message = "Your Departements page.";

            return View();
        }
        public ActionResult Reports()
        {
            ViewBag.Message = "Your Departements page.";

            return View();
        } 
        public ActionResult Login()
        {
            ViewBag.Message = "Your Departements page.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Your Departements page.";

            return View();
        }
    }
}