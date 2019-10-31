using SkyOrder_Paup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyOrder_Paup.Models
{
    public class RestoranDb
    {
        private static List<Restoran> ListaRestorani = new List<Restoran>();
        private static bool napunjeno = false;

        public RestoranDb()
        {
            if (!napunjeno) {

                napunjeno = true;
                ListaRestorani.Add(new Restoran
                {
                    id_restoran = 0,
                    lozinka = "asd",
                    naziv = "Pozitiva",
                    adresa = "haha 12",
                    mail = "asdf@asd",
                    kontakt = "099595959"
                });
                ListaRestorani.Add(new Restoran
                {
                    id_restoran = 1,
                    lozinka = "asfdsadf",
                    naziv = "BARAKA",
                    adresa = "asdfrqwer 123123",
                    mail = "asdf@ffff",
                    kontakt = "095656565"
                });
            }
        }
        public List<Restoran> VratiRestoran()
        {
            return ListaRestorani;
        }
        public void AzurirajRestoran(Restoran r)
        {
            foreach (Restoran e in ListaRestorani)
            {
                if (e.id_restoran == r.id_restoran)
                {
                    ListaRestorani[e.id_restoran] = r;
                }
            }
        }

        public void DodajRestoran(Restoran r)
        {
            bool postoji = false;
            int index;
            foreach (Restoran p in ListaRestorani)
            {
                if (p.id_restoran == r.id_restoran)
                {
                    postoji = true;
                }
            }
            if (postoji)
            {
                ListaRestorani[r.id_restoran] = r;
            }
            else
            {
                int noviId = (from rt in ListaRestorani select rt).Max(x => x.id_restoran) + 1;
                r.id_restoran = noviId;
                ListaRestorani.Add(r);
            }

        }
        public void ObrisiRestoran(Restoran r)
        {
            int indeks = ListaRestorani.FindIndex(x => x.id_restoran == r.id_restoran);
            ListaRestorani.RemoveAt(indeks);
        }
    }
}