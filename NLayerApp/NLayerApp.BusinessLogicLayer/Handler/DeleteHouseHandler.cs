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

        public void DeleteHouse(int id)
        {
            this.unitOfWork.GenericRepository<House>().Delete(id);
            this.unitOfWork.GenericRepository<Info>().Delete(id);
            this.unitOfWork.GenericRepository<Communication>().Delete(id);
            this.unitOfWork.GenericRepository<AdditionalEquipment>().Delete(id);
            this.unitOfWork.SaveChanges();
        }
    }
}
