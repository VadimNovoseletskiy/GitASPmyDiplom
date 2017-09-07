using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Interface
{
    /// <summary>
    /// The Repository Interface
    /// To increase the flexibility of connecting to a database, repositories are used
    /// Add the IRepository repository interface
    /// </summary>
    /// <typeparam name="TEntity">
    /// Any reference type 
    /// </typeparam>
    public interface IGenericRepository<T>
        where T:class
    {
        /// <summary>
        /// The Find 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// The <see cref="TEntity"/>
        /// </returns>
        T Find(object id);
        /// <summary>
        /// The Get
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>
        /// </returns>
        IQueryable<T> Get();
        /// <summary>
        /// The insert
        /// </summary>
        /// <param name="entity"></param>
        void Insert(T entity);
        /// <summary>
        /// The insert Photo 
        /// </summary>
        /// <param name="entity"></param>
        void InsertPhoto(T entity);
        /// <summary>
        /// The update 
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// The delete 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
        /// <summary>
        /// The delete 
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);
    }
}
