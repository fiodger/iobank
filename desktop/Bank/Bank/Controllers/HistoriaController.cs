using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Controllers
{
    public class HistoriaController : Controller
    {
        //
        // GET: /Historia/

        public ActionResult Index()
        {
            ViewBag.Message = "Tu Bedzie Strona o historii.";
            return View();
        }

    }
}
