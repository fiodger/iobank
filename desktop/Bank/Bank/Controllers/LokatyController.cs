﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Controllers
{
    public class LokatyController : Controller
    {
        //
        // GET: /Lokaty/

        public ActionResult Index()
        {
            ViewBag.Message = "Tu Bedzie Strona Zarzadzania lokatami.";
            return View();
        }

    }
}