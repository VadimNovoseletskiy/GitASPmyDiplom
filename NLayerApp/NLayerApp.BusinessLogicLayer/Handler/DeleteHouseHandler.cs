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
    public class DeleteHouseHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteHouseHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DeleteHouseHandler() : this(new UnitOfWork())
        {

        }

        public DeleteHouseViewModel DeleteFindHouse(int? id) =>
            this.unitOfWork.GenericRepository<House>()
            .Get()
            .Where(x => x.Id == id)
            .Select(
                        x => new DeleteHouseViewModel
                        {
                            Id = x.Id,
                            Region = x.Info.RegionId.Value,
                            Village = x.Info.VillageId.Value,
                            Street = x.Info.StreetId.Value,
                            NumberAdress = x.Info.AddressNumber,
                            OperationType = x.Info.OperationType,
                            LivingAreaHouse = x.LivingAreaHouse,
                            InfoDetails = x.Info.DetailsInfo,
                        }
                    )
            .FirstOrDefault();

        public int DeleteFindCommunication(int? id)
        {
            var firstOrDefault = this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(x => x.CommunicationId)
                .FirstOrDefault();
            return (int)firstOrDefault;
        }

        public int DeleteFindAdditionalEquipment(int? id)
        {
            var firstOrDefault = this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(x => x.AdditionalEquipmentId)
                .FirstOrDefault();

            return (int)firstOrDefault;

        }


        public void DeleteHouse(int id)
        {
            int idCommunication = DeleteFindCommunication(id);
            int idAdditionalEquipment = DeleteFindAdditionalEquipment(id);
            this.unitOfWork.GenericRepository<House>().Delete(id);
            this.unitOfWork.GenericRepository<Info>().Delete(id);
            this.unitOfWork.GenericRepository<Communication>().Delete(idCommunication);
            this.unitOfWork.GenericRepository<AdditionalEquipment>().Delete(idAdditionalEquipment);
            this.unitOfWork.SaveChanges();
        }
    }
}
