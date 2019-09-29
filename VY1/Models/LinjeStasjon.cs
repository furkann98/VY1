using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VY1.Models
{
    public class LinjeStasjon
    {
        public int Id { get; set; }
        public virtual Linje Linje { get; set; }
        public virtual Stasjon Stasjon { get; set; }

    }
}