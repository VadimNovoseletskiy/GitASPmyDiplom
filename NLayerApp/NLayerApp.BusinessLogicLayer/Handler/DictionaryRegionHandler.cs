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
     public class DictionaryRegionHandler
     {
         private readonly IUnitOfWork unitOfWork;

         public DictionaryRegionHandler(IUnitOfWork unitOfWork)
         {
             this.unitOfWork = unitOfWork;
         }

         public DictionaryRegionHandler() : this(new UnitOfWork())
         {
             
         }

         public List<RegionViewModel> RegionOutPut() =>
             this.unitOfWork.GenericRepository<Region>()
                 .Get()
                 .Select(p => new RegionViewModel
                 {
                     Id = p.Id,
                     Region = p.RegionName
                 }

                 )
                 .ToList<RegionViewModel>();

        public void InsertRegion(RegionInputParameters parameters)
        {
            Region myRegion = new Region { RegionName = parameters.NameRegion };
            this.unitOfWork.GenericRepository<Region>().InsertGraph(myRegion);
            this.unitOfWork.SaveChanges();
        }

         public Region Find(object id) =>
             this.unitOfWork.GenericRepository<Region>().Find(id);
       

        public void Update(Region region)
        {
            this.unitOfWork.GenericRepository<Region>().Update(region);
            this.unitOfWork.SaveChanges();
        }
    }
}
