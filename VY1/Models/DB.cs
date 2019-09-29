using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace VY1.Models
{
    public class DB:DbContext
    {
        public DB() : base("name=DB")
        {
            Database.CreateIfNotExists();
            Database.SetInitializer(new DBInit());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

        }


        public virtual DbSet<Linje> linjer { get; set; }
        public virtual DbSet<Stasjon> Stasjoner { get; set; }
        public virtual DbSet<LinjeStasjon> linjeStasjoner { get; set; }
    }
}