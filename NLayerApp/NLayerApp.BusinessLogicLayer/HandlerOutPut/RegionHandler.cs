using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class RegionHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public RegionHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public RegionHandler()
            : this(new UnitOfWork())
        {
        }

    }
}
