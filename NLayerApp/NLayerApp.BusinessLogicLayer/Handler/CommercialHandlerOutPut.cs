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
    public class CommercialHandlerOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public CommercialHandlerOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public CommercialHandlerOutPut() : this(new UnitOfWork())
        {

        }

        public List<CommercialViewModel> GetCommercial(CommercialSearchParameters parameters) =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(p => p.Type == PropertyType.Commercial
                            && p.VillageId == parameters.Village
                            && p.RegionId == parameters.Region
                            && p.OperationType == parameters.TypeOperation
                            && p.Commercial.TypeCommercial == parameters.TypeCommercial
                            || p.DollarPrice <= parameters.DollarPriceTo
                            || p.GrnPrice <= parameters.GrnPriceTo

                )
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
