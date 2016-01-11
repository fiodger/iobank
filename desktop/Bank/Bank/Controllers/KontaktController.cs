using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Transactions;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using Bank.Filters;
using Bank.Models;



namespace Bank.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class KontaktController : Controller
    {
        [AllowAnonymous]
        public ActionResult Kontakt()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Kontakt(KontaktModel model)
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
