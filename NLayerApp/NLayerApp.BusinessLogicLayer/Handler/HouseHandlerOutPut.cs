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
    public class HouseHandlerOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public HouseHandlerOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public HouseHandlerOutPut() : this(new UnitOfWork())
        {

        }

        public List<HouseViewModel> GetHouse(HouseSearchParameters parameters) =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(p => p.Type == PropertyType.House
                            && p.RegionId == parameters.Region
                            && p.VillageId == parameters.Village
                            && p.OperationType == parameters.OperationType
                            && p.House.TypeHouse == parameters.TypeHouse
                            && p.House.PartHouse == parameters.PartHouse
                            && p.DollarPrice >= parameters.DollarPriceFrom
                            && p.DollarPrice <= parameters.DollarPriceTo
                            && p.GrnPrice >= parameters.GrnPriceFrom
                            && p.GrnPrice <= parameters.GrnPriceTo
                )
                .Select(p => new HouseViewModel
                        {
                            Id = p.Id,
                            CaptionLint = p.NameCaptionLink,
                            Village = p.Village.VillageName,
                            Region = p.Region.RegionName,
                            TypeHouse = p.House.TypeHouse,
                            Floor = p.House.FloorHouse,
                            TotalArea = p.TotalAreaInfo

                        }
                )
                .ToList<HouseViewModel>();

    }
}
    