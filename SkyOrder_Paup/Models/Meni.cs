using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyOrder_Paup.Models
{
    public class Meni
    {
        public int id_restorana { get; set; }
        public int id_hrana { get; set; }
        public string naziv { get; set; }
        public double cijena { get; set; }

    }
}