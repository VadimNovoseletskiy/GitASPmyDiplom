using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class DictunaryHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DictunaryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DictunaryHandler() : this(new UnitOfWork())
        {
        }

        public void InsertRegion(RegionInputParameters parameters)
        {
            Region myRegion=new Region {RegionName = parameters.NameRegion};
            this.unitOfWork.GenericRepository<Region>().Insert(myRegion);
        }
    }
}
