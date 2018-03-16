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
    public class ApartmentHandlerAllOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public ApartmentHandlerAllOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public ApartmentHandlerAllOutPut() : this(new UnitOfWork())
        {

        }

        public List<ApartmentViewModel> GetAllApartment() =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(p => p.Type == PropertyType.Apartment)
                .Select(p => new ApartmentViewModel
                {
                    Id = p.Id,
                    CaptionLink = p.NameCaptionLink,
                    Region = p.Region.RegionName,
                    Village = p.Village.VillageName,
                    OperationType = p.OperationType,
                    TotalFloorApartment = p.Apartment.TotalFloorApartment,
                    WallMaterial = p.WallMaterial.NameWallMaterils,
                    FloorMaterial = p.FloorMaterial.NameFloorMaterils,
                    Floor = p.Apartment.FloorApartment,
                    NumberOfRooms = p.Apartment.RoomsApartment,
                    TotalAreaInfo = p.TotalAreaInfo,
                    DollarPrice = p.DollarPrice,
                    GrnPrice = p.GrnPrice,
                }).ToList<ApartmentViewModel>();

        
    }
}
