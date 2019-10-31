using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyOrder_Paup.Models
{
    public class Restoran
    {
        public int id_restoran { get; set; }
        public string lozinka { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string mail { get; set; }
        public string kontakt { get; set; }

        public string VratiNazivRestoran()
        {
            return naziv;
        }
    }
}