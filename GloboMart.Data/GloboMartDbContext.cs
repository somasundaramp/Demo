using GloboMart.Model;
using GloboMart.Model.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Data
{
    public class GloboMartDbContext : IdentityDbContext<IdentityUser>
    {
        public GloboMartDbContext() : 
            base("DefaultConnection")
        {
            Database.SetInitializer<GloboMartDbContext>(null);
            Configuration.LazyLoadingEnabled = true;
        }

        DbSet<Product> Products { get; set; }
        DbSet<ProductType> ProductType { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
