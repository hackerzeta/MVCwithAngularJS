﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithAngularJS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        { 
        
            return View();
        
        }

        public ActionResult Part2 () 
        {

            return View();

        }

        public ActionResult Part3()
        {
            return View();
        }

    }
}
