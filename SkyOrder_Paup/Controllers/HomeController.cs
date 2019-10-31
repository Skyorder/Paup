using SkyOrder_Paup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyOrder_Paup.Controllers
{
    public class HomeController : Controller
    {
        private RestoranDb ListaRestorani = new RestoranDb();
        private HranaDb ListaHrana = new HranaDb();
        private MeniDb ListaMeni = new MeniDb();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Onama()
        {
            return View();
        }

        public ActionResult Kontakt()
        {
            return View();
        }

        public ActionResult Restorani()
        {
            return View(ListaRestorani);
        }

        public ActionResult Meni(int id)
        {
            ListaMeni.filtrirajListu(id,ListaHrana.VratiHranu());
            return View(ListaMeni);
        }
    }
}