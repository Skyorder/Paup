using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyOrder_Paup.Models
{
    public class Hrana
    {
        public int id_hrana { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }

        public string VratiNazivHrana()
        {
            return naziv;
        }
    }
}