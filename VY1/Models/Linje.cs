using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VY1.Models
{
    public class Linje
    {

        public int Id { get; set; }
        public String Navn { get; set; }

        public virtual List<Stasjon> stasjoner { get; set; }
        
    }
}