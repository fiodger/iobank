using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Controllers
{
    public class PrzelewyController : Controller
    {
        //
        // GET: /Przelewy/

        public ActionResult Index()
        {
            ViewBag.Message = "Tu Bedzie Strona Zarzadzania przelewami.";
            return View();

        }

    }
}
