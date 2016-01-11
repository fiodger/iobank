using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/

        public ActionResult Index()
        {
            ViewBag.Message = "Tu Bedzie Strona z danymi pieniężnymi.";
            return View();
        }

    }
}
