using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Interface
{
    /// <summary>
    /// The Database Context interface 
    /// </summary>
    public interface IDbContext:IDisposable
    {
        /// <summary>
        /// The set
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>
        /// The <see cref="IDbSet{T}"/>
        /// </returns>
        IDbSet<T> Set<T>()
            where T : class;
        // <summary>
        /// The save changes
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>
        /// </returns>
        int SaveChanges();
        /// <summary>
        /// The entry.
        /// </summary>
        /// <param name="o">
        /// The o.
        /// </param>
        /// <returns>
        /// The <see cref="DbEntityEntry"/>
        /// </returns>
        DbEntityEntry Entry(object o);
        // <summary>
        /// The begin transaction
        /// </summary>
        /// <returns>
        /// The <see cref="IDbTransaction"/>
        /// </returns>
        DbContextTransaction BeginTransaction();

    }
}
