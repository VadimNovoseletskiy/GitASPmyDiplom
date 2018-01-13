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
    public class DeleteApartmentHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteApartmentHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DeleteApartmentHandler() : this(new UnitOfWork())
        {

        }

        public DeleteApartmentViewModel DeleteFindApartment(int? id) =>
            this.unitOfWork.GenericRepository<Apartment>()
            .Get()
            .Where(x => x.Id == id)
            .Select(
                        x => new DeleteApartmentViewModel
                        {
                            Id = x.Id,
                            Region = x.Info.RegionId.Value,
                            Village = x.Info.VillageId.Value,
                            Street = x.Info.StreetId.Value,
                            NumberAdress = x.Info.AddressNumber,
                            OperationType = x.Info.OperationType,
                            RoomsApartment=x.RoomsApartment,
                            TypeRoom = x.TypeRoom,
                            InfoDetails = x.Info.DetailsInfo,
                            ApartmentNumber = x.ApartmentNumber,
                           
                        }
                    )
            .FirstOrDefault();

        public int DeleteFindAdditionalEquipment(int? id)
        {
            var firstOrDefault = this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(x => x.AdditionalEquipmentId)
                .FirstOrDefault();
          
                return (int) firstOrDefault;
            
        }

        public List<DeleteAllimageViewModel> GetAllDeleteImages(int? id) =>
            this.unitOfWork.GenericRepository<Picture>()
                .Get()
                .Where(p => p.InfoId == id)
                .Select(p => new DeleteAllimageViewModel
                {
                    IdPicture = p.Id,
                    InfoId = p.InfoId.Value
                })
                .ToList<DeleteAllimageViewModel>();


        public void DeleteApartment(int id)
        {
            var resultDelImg = GetAllDeleteImages(id);
            foreach (var b in resultDelImg)
            {
                this.unitOfWork.GenericRepository<Picture>().Delete(b.IdPicture);
            }

            int idAdditionalEquipment = DeleteFindAdditionalEquipment(id);


            this.unitOfWork.GenericRepository<Apartment>().Delete(id);
            this.unitOfWork.GenericRepository<Info>().Delete(id);
            this.unitOfWork.GenericRepository<AdditionalEquipment>().Delete(idAdditionalEquipment);
            this.unitOfWork.SaveChanges();
        }
    }
}
