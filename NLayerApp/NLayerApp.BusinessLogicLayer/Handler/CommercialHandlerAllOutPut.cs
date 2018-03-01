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
    public class CommercialHandlerAllOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public CommercialHandlerAllOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public CommercialHandlerAllOutPut() : this(new UnitOfWork())
        {

        }

        public List<CommercialViewModel> GetAllCommercial() =>
           this.unitOfWork.GenericRepository<Info>()
               .Get()
               .Where(p => p.Type == PropertyType.Commercial)
               .Select(p => new CommercialViewModel
               {
                   Id = p.Id,
                   Village = p.Village.VillageName,
                   Region = p.Region.RegionName,
                   StateCommercial = p.Commercial.StateCommercial,
                   TotalArea = p.TotalAreaInfo,
                   DollarPrice = p.DollarPrice,
                   GrnPrice = p.GrnPrice,
                   CaptionLink = p.NameCaptionLink,
                   OperationType = p.OperationType
               }
               )
               .ToList<CommercialViewModel>();
    }
}
