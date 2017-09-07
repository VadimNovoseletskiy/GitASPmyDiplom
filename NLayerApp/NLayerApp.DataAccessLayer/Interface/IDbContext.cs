using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Interface
{
    public interface IDbContext:IDisposable
    {
        IDbSet<T> Set<T>()
            where T : class;

        int SaveChanges();
        DbEntityEntry Entry(object o);
        DbContextTransaction BeginTransaction();

    }
}
