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


        /// <inheritdoc/>
        public new IDbSet<T> Set<T>()
            where T : class => base.Set<T>();
        /// <inheritdoc/>
        public DbContextTransaction BeginTransaction() => this.Database.BeginTransaction();

    }
}
