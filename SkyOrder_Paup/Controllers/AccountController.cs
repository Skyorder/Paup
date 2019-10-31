using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyOrder_Paup.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Prijava()
        {
            return View();
        }

        public ActionResult Registracija()
        {
            return View();
        }
    }
}