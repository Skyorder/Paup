using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyOrder_Paup.Models
{
    public class MeniDb
    {
        private List<Meni> MeniLista = new List<Meni>();
        private List<Meni> filtriranaLista = new List<Meni>();

        public MeniDb()
        {
            MeniLista.Add(new Meni
            {
                id_hrana = 0,
                id_restorana = 0,
                cijena = 22.99
            });
            MeniLista.Add(new Meni
            {
                id_hrana = 1,
                id_restorana = 0,
                cijena = 15.50
            });
            MeniLista.Add(new Meni
            {
                id_hrana = 3,
                id_restorana = 0,
                cijena = 22.99
            });
            MeniLista.Add(new Meni
            {
                id_hrana = 0,
                id_restorana = 1,
                cijena = 22.99
            });
            MeniLista.Add(new Meni
            {
                id_hrana = 2,
                id_restorana = 1,
                cijena = 22.99
            });
            MeniLista.Add(new Meni
            {
                id_hrana = 3,
                id_restorana = 0,
                cijena = 10.50
            });
        }
       
        public void filtrirajListu(int id, List<Hrana> ListaHrana)
        {
            foreach (Hrana h in ListaHrana)
            {
                foreach (Meni m in MeniLista)
                {
                    if (m.id_hrana == h.id_hrana)
                    {
                        m.naziv = h.naziv;
                    }
                }
            }

            foreach (Meni m in MeniLista)
            {
                if (m.id_restorana == id)
                { 
                    filtriranaLista.Add(m);
                }
            }
        }
        public List<Meni> VratiMani()
        {
            return filtriranaLista;
        }
    }
}