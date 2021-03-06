﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TourGuide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tour Guide Inc. is a city guide to all the hottest hotels and restaurants in your area.";

            ViewBag.Message = "The name of our company is TourGuide Inc.";
            ViewBag.Message = "This web application is a city guide to hotels and restaurants.";


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }
    }
}