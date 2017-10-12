using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains;
using NLayerApp.DataAccessLayer.Interface;

namespace NLayerApp.DataAccessLayer.Repository
{
    /// <summary>
    /// The unit of work.
    /// </summary>
    public class UnitOfWork:IUnitOfWork
    {
        /// <summary>
        /// The "Hashtable" class is designed to create a collection, in which a hash table serves 
        /// to store its elements. Information is stored in the hash table using a mechanism called hashing.
        /// </summary>
        private Hashtable respositories;

        private readonly IDbContext context;

        public UnitOfWork() : this(new MyContext())
        {
        }

        public UnitOfWork(IDbContext context)
        {
            this.context = context;
            this.respositories = new Hashtable();
        }

        ///<iheritdoc/>
        public IGenericRepository<TEntity> GenericRepository<TEntity>() where TEntity : class
        {
            var type = typeof(TEntity).Name;
            if (!this.respositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repository =
                    Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), this.context);
                this.respositories.Add(type,repository);
            }
            return (IGenericRepository<TEntity>)this.respositories[type];
        }


        ///<iheritdoc/>
        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
