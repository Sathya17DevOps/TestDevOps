﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevOpsTestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. yes it is application page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. yes it  yest it is";

            return View();
        }
    }
}