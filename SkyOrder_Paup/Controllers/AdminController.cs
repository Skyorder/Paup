using SkyOrder_Paup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SkyOrder_Paup.Controllers
{
    public class AdminController : Controller
    {
        private RestoranDb ListaRestorani = new RestoranDb();
        private HranaDb ListaHrana = new HranaDb();
        private MeniDb ListaMeni = new MeniDb();

        

        public ActionResult Index()
        {
            return View();
        }
        // RESTORANI ------------------------------------------------------------------------

        public ActionResult RestoraniPregled()
        {
            return View(ListaRestorani);
        }

        //AZURIRAJ
        public ActionResult AzurirajRestoran(int? id)
        {
            Restoran r;
            if (id == null)
            {
                r = new Restoran();
                ViewBag.Title = "Unos novog restorana";
            }
            else
            {
                r = ListaRestorani.VratiRestoran().Find(rt => rt.id_restoran == id);
                if (r == null)
                {
                    return HttpNotFound();
                }
                ViewBag.Title = "Ažuriranje podataka o restoranu";
            }
            return View(r);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AzurirajRestoran(
            [Bind(Include ="id_restoran,naziv,adresa,kontakt,mail")] Restoran r
            )
        {
            if (r.id_restoran != 0)
            {
                ListaRestorani.AzurirajRestoran(r);
            }
            else
            {
                ListaRestorani.DodajRestoran(r);
                return RedirectToAction("RestoraniPregled");
            }
            return View(r);
        }

        //OBRISI
        public ActionResult ObrisiRestoran(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restoran r = ListaRestorani.VratiRestoran().Find(x => x.id_restoran == id);
            if (r == null)
            {
                return HttpNotFound();
            }
            ViewBag.Title = "Brisanje restorana";
            return View(r);
        }
        [HttpPost, ActionName("ObrisiRestoran")]
        [ValidateAntiForgeryToken]
        public ActionResult ObrisiRestoranPotvrda(int id)
        {
            Restoran r = ListaRestorani.VratiRestoran().Find(x => x.id_restoran == id);
            ListaRestorani.ObrisiRestoran(r);
            return RedirectToAction("RestoraniPregled");
        }
        //DETALJNO
        public ActionResult DetaljiRestoran(int? id)
        {
            ViewBag.Title = "Podaci o restoranu";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // lambda izraz koji traži prvog studenta s Id-om koji je zadan
            Restoran r = ListaRestorani.VratiRestoran().Find(st => st.id_restoran == id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        // KORISNICI --------------------------------------------------------------------
        public ActionResult KorisniciPregled()
        {
            return View();
        }

        // HRANA -----------------------------------------------------------------------
        public ActionResult HranaPregled()
        {
            return View(ListaHrana);
        }
        //AZURIRAJ
        public ActionResult AzurirajHrana(int? id)
        {
            Hrana h;
            if (id == null)
            {
                h = new Hrana();
                ViewBag.Title = "Unos novog restorana";
            }
            else
            {
                h = ListaHrana.VratiHranu().Find(rt => rt.id_hrana == id);
                if (h == null)
                {
                    return HttpNotFound();
                }
                ViewBag.Title = "Ažuriranje podataka o restoranu";
            }
            return View(h);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AzurirajHrana(
            [Bind(Include = "id_hrana,naziv,opis")] Hrana h
            )
        {
            if (h.id_hrana != 0)
            {
                ListaHrana.AzurirajHrana(h);
            }
            else
            {
                ListaHrana.DodajHrana(h);
                return RedirectToAction("HranaPregled");
            }
            return View(h);
        }

        //OBRISI
        public ActionResult ObrisiHrana(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hrana h = ListaHrana.VratiHranu().Find(x => x.id_hrana == id);
            if (h == null)
            {
                return HttpNotFound();
            }
            ViewBag.Title = "Brisanje hrane";
            return View(h);
        }
        [HttpPost, ActionName("ObrisiHrana")]
        [ValidateAntiForgeryToken]
        public ActionResult ObrisiHranaPotvrda(int id)
        {
            Hrana h =ListaHrana.VratiHranu().Find(x => x.id_hrana == id);
            ListaHrana.ObrisiHrana(h);
            return RedirectToAction("HranaPregled");
        }
        //DETALJNO
        public ActionResult DetaljiHrana(int? id)
        {
            ViewBag.Title = "Podaci o hrani";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // lambda izraz koji traži prvog studenta s Id-om koji je zadan
            Hrana h = ListaHrana.VratiHranu().Find(st => st.id_hrana == id);
            if (h == null)
            {
                return HttpNotFound();
            }
            return View(h);
        }

    }
}