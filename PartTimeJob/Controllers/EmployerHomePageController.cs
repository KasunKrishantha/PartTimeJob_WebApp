﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartTimeJob.Controllers
{
    public class EmployerHomePageController : Controller
    {
        // GET: EmployerHomePage
        public ActionResult Home()
        {
            return View();
        }

        // GET: EmployerHomePage/CreateJob
        public ActionResult CreateJob()
        {
            return View();
        }
    }
}