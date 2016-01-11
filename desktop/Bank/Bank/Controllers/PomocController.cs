using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Controllers
{
    public class PomocController : Controller
    {
        //
        // GET: /Pomoc/

        public ActionResult Pomoc()
        {

            ViewBag.Message = "Strona Pomocy.";
            return View();
        }

        public ActionResult Kontakt()
        {

            ViewBag.Message = "Strona z kontaktami twórców.";
            return View();
        }

    }
}
