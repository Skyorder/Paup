using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyOrder_Paup.Models
{
    public class HranaDb
    {
        private static List<Hrana> HranaLista = new List<Hrana>();
        private string ime;
        private static bool napunjeno = false;

        public HranaDb()
        {
            if (!napunjeno)
            {
                napunjeno = true;
                HranaLista.Add(new Hrana
                {
                    id_hrana = 0,
                    naziv ="Khrokhodhil"
                });
                HranaLista.Add(new Hrana
                {
                    id_hrana = 1,
                    naziv = "Kolac"
                });
                HranaLista.Add(new Hrana
                {
                    id_hrana = 2,
                    naziv = "Kava"
                });
                HranaLista.Add(new Hrana
                {
                    id_hrana = 3,
                    naziv = "Kobas"
                });
            }
        }
        public List<Hrana> VratiHranu()
        {
            return HranaLista;
        }
        public string VratiNaziv(int id)
        {

            foreach (Hrana h in HranaLista)
            {
                if (id == h.id_hrana)
                {
                    ime = h.naziv;
                }
            }
            return ime;
        }

        public void AzurirajHrana(Hrana h)
        {
            foreach (Hrana e in HranaLista)
            {
                if (e.id_hrana == h.id_hrana)
                {
                    HranaLista[e.id_hrana] = h;
                }
            }
        }

        public void DodajHrana(Hrana h)
        {
            bool postoji = false;
            foreach (Hrana p in HranaLista)
            {
                if (p.id_hrana == h.id_hrana)
                {
                    postoji = true;
                }
            }
            if (postoji)
            {
                HranaLista[h.id_hrana] = h;
            }
            else
            {
                int noviId = (from rt in HranaLista select rt).Max(x => x.id_hrana) + 1;
                h.id_hrana = noviId;
                HranaLista.Add(h);
            }

        }
        public void ObrisiHrana(Hrana h)
        {
            int indeks = HranaLista.FindIndex(x => x.id_hrana == h.id_hrana);
            HranaLista.RemoveAt(indeks);
        }
    }
}