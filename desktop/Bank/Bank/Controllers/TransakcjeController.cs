using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Controllers
{
    public class TransakcjeController : Controller
    {
        //
        // GET: /Transakcje/

        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Transakcje/Przelewy/

        public ActionResult Przelewy()
        {
            ViewBag.Message = "Tu Bedzie Strona Zarzadzania przelewami.";
            return View();
        }
    }
}
