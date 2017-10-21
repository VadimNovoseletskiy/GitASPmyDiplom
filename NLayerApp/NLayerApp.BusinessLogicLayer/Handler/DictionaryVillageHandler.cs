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
     public class DictionaryVillageHandler
     {
         private readonly IUnitOfWork unitOfWork;

         public DictionaryVillageHandler(IUnitOfWork unitOfWork)
         {
             this.unitOfWork = unitOfWork;
         }

         public DictionaryVillageHandler() : this(new UnitOfWork())
         {

         }
        //OutPut
         public List<VillageViewModels> GetVillages() =>
             this.unitOfWork.GenericRepository<Village>()
                 .Get()
                 .Select(
                     p => new VillageViewModels
                     {
                         Id = p.Id,
                         Village = p.VillageName
                     }
                 )
                 .ToList<VillageViewModels>();

         public void InsertVillage(VillageInputParameters parameters)
         {
            Village myVillage=new Village {VillageName = parameters.Village};
            this.unitOfWork.GenericRepository<Village>().InsertGraph(myVillage);
            this.unitOfWork.SaveChanges();
         }

         public Village FindVillage(object id) =>
             this.unitOfWork.GenericRepository<Village>().Find(id);

         public void UpdateViillage(Village village)
         {
            this.unitOfWork.GenericRepository<Village>().Update(village);
            this.unitOfWork.SaveChanges();
         }
     }
}
