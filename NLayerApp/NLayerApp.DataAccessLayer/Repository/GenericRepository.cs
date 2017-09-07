using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;

namespace NLayerApp.DataAccessLayer.Repository
{
    /// <summary>
    /// The Generic Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepository<T>:IGenericRepository<T>
        where T:class
    {
        /// <summary>
        /// The Context 
        /// </summary>
        private readonly IDbContext context;



        /// <summary>
        /// The constructor 
        /// Initializes a new instance of the <see cref="GenericRepository{T}"/>
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(IDbContext context)
        {
            this.context = context;
        }


        /// <summary>
        /// The database set
        /// </summary>
        private IDbSet<T> DbSet => this.context.Set<T>();


        ///<inherdoc/>
        public T Find(object id)
        {
            return this.DbSet.Find(id);
        }

        ///<inheritdoc/>
        public IQueryable<T> Get()
        {
            return this.DbSet;
        }

        ///<inheritdoc/>
        public void Insert(T entity)
        {
            this.DbSet.Attach(entity);
        }

        ///<inheritdoc/>
        public void InsertPhoto(T entity)
        {
            this.DbSet.Add(entity);
        }

        ///<inheritdoc/>
        public void Update(T entity)
        {
            if (this.context.Entry(entity).State == EntityState.Deleted)
            {
                this.DbSet.Attach(entity);
            }
            this.context.Entry(entity).State = EntityState.Modified;
        }

        ///<inheritdoc/>
        public void Delete(T entity)
        {
            if (this.context.Entry(entity).State == EntityState.Deleted)
            {
                this.DbSet.Attach(entity);
            }
            this.context.Entry(entity).State = EntityState.Deleted;
        }

        /// <inheritdoc />
        public void Delete(object id)
        {
            var entity = this.FindById(id);
            this.Delete(entity);
        }






    }
}
