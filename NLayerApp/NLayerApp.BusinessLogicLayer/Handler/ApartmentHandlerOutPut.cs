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
    public class ApartmentHandlerOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public ApartmentHandlerOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public ApartmentHandlerOutPut() : this(new UnitOfWork())
        {

        }

        public List<ApartmentViewModel> GetApartment(ApartmentSearchParameters parameters) =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(p => p.Type == PropertyType.Apartment
                            && p.RegionId == parameters.Region
                            && p.VillageId == parameters.Village
                            && p.OperationType == parameters.OperationType
                            && p.Apartment.TypeRoom == parameters.TypeRoom
                            && p.Apartment.RoomsApartment == parameters.RoomsApartment
                            && p.DollarPrice<=parameters.DollarCostTo
                            && p.GrnPrice<=parameters.GrnCostTo
                            )

                .Select(p => new ApartmentViewModel
                {
                    Id = p.Id,
                    CaptionLink = p.NameCaptionLink,
                    Region = p.Region.RegionName,
                    Village = p.Village.VillageName,
                    OperationType = p.OperationType,
                    Floor = p.Apartment.FloorApartment,
                    NumberOfRooms = p.Apartment.RoomsApartment,
                    TotalAreaInfo = p.TotalAreaInfo,
                    DollarPrice = p.DollarPrice,
                    GrnPrice = p.GrnPrice,
                }
    )
            .ToList<ApartmentViewModel>();
    }
}
