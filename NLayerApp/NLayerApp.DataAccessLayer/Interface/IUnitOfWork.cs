using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Interface
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// The get repository
        /// </summary>
        /// <typeparam name="TEntity">
        /// Any reference type 
        /// </typeparam>
        /// <returns>
        /// The <see cref="IGerericRepository{TEntity}"/>
        /// </returns>
        IGenericRepository<T> GenericRepository<T>() where T : class;
        /// <summary>
        /// The save changes 
        /// </summary>
        void SaveChanges();

    }
}
