using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;

namespace NLayerApp.DataAccessLayer.Domains
{
    public class MyContext:DbContext,IDbContext
    {
        /// <summary>
        /// Add Initializer in the static constructor
        /// </summary>
        static MyContext()
        {
         Database.SetInitializer<MyContext>(new MyContextInitializer());
        }


        /// <summary>
        /// The Constructor
        /// </summary>
        public MyContext() : base("MyConnection")
        {
            /*To disable lazy loading for all objects in the context,
            Set its configuration property to false*/
            this.Configuration.LazyLoadingEnabled = false;
            /*To improve performance,
            turn off detection of changes*/
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        /// <summary>
        /// The DbSets
        /// The properties that will receive a data Set or Get from the database 
        /// </summary>
        public DbSet<Info> Infos { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Commercial> Commercials { get; set; }
        public DbSet<Land> Land{ get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<OutBuilding> OutBuildings { get; set; }
        public DbSet<AdditionalEquipment> AdditionalEquipments { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<WallMaterial> WallMaterials { get; set; }
        public DbSet<FloorMaterial> FloorMaterials { get; set; }








        /// <inheritdoc/>
        public new IDbSet<T> Set<T>()
            where T : class => base.Set<T>();
        /// <inheritdoc/>
        public DbContextTransaction BeginTransaction() => this.Database.BeginTransaction();

    }
}
