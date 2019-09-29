using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VY1.Models
{
    public class DBInit:DropCreateDatabaseAlways<DB>
    {
        protected override void Seed(DB context)
        {
            var linje = new Linje()
            {
                Navn = "L1"

            };


            var liste2 = new List<Linje>();

            var stasjon1 = new Stasjon()
            {
                Navn = "Oslo",
                Linjer = liste2

            };

            var stasjon2 = new Stasjon()
            {
                Navn = "Ski",
                Linjer = liste2

            };

            var linjeStasjon = new LinjeStasjon()
            {
                Stasjon = stasjon1,
                Linje = linje
            };

            var linjeStasjon2 = new LinjeStasjon()
            {
                Stasjon = stasjon2,
                Linje = linje
            };


            var liste1 = new List<Stasjon>();
            liste1.Add(stasjon1);
            liste1.Add(stasjon2);

            linje.stasjoner = liste1;


            context.linjer.Add(linje);
            context.Stasjoner.Add(stasjon1);
            context.Stasjoner.Add(stasjon2);
            context.linjeStasjoner.Add(linjeStasjon);
            context.linjeStasjoner.Add(linjeStasjon2);
            base.Seed(context);
        }

    }
}