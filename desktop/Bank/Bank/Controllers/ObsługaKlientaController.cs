using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Controllers
{
    public class ObsługaKlientaController : Controller
    {
        //
        // GET: /ObsługaKlienta/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET:  /ObsługaKlienta/Wnioski

        public ActionResult Wnioski()
        {
            return View();
        }

        //
        // GET:  /ObsługaKlienta/Zarzadzaj

        public ActionResult Zarzadzaj()
        {
            return View();
        }

        //
        // GET:  /ObsługaKlienta/Zgłoszenia

        public ActionResult Zgłoszenia()
        {
            return View();
        }

        //
        // GET:  /ObsługaKlienta/Klienci

        public ActionResult Klienci()
        {
            return View();
        }
        //
        // GET:  /ObsługaKlienta/Kontakt

        public ActionResult Kontakt()
        {
            return View();
        }

        //
        // GET:  /ObsługaKlienta/FAQ

        public ActionResult FAQ()
        {
            return View();
        } 
    }
}
