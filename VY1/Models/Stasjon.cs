using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VY1.Models
{
    public class Stasjon
    {
        public int Id { get; set; }
        public String Navn { get; set; }
        public virtual List<Linje> Linjer { get; set; }

    }
}