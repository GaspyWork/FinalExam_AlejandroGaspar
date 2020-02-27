using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.DAL
{
    public class IBMContext : DbContext
    {
        public IBMContext() : base("IBMContext")
        {
        }

        public DbSet<ConversionModelBD> Conversiones { get; set; }
        public DbSet<TransacionModelBD> Transaciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}