using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class DeleteLandHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteLandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DeleteLandHandler() : this(new UnitOfWork())
        {

        }
        
        public DeleteLandViewModel DeleteFindLand(int ?id) =>
            this.unitOfWork.GenericRepository<Land>()
            .Get()
            .Where(x=>x.Id==id)
            .Select(
                        x=>new DeleteLandViewModel
                        {
                            Id = x.Id,
                            Region = x.Info.RegionId.Value,
                            Village = x.Info.VillageId.Value,
                            Street = x.Info.StreetId.Value,
                            NumberAdress = x.Info.AddressNumber,
                            OperationType = x.Info.OperationType,
                            TypeLand = x.SpecialLand,
                            InfoDetails = x.Info.DetailsInfo,
                            LandArea = x.LandArea
                           
                        }
                    )
            .FirstOrDefault();

        public void DeleteLand(int id)
        {
            //var myLand = unitOfWork.GenericRepository<Land>()
            //   .Get()
            //   .Include(x => x.Info)
            //   .FirstOrDefault();

            this.unitOfWork.GenericRepository<Land>().Delete(id);
            this.unitOfWork.GenericRepository<Info>().Delete(id);
            this.unitOfWork.GenericRepository<Communication>().Delete(id);
            this.unitOfWork.SaveChanges();
        }

    }
}





//var myLand = unitOfWork.GenericRepository<Land>()
//   .Get()
//   .Include(x => x.Info)
//   .FirstOrDefault();

//land.Info.RegionId= viewModel.Region;
//land.Info.Id= viewModel.Village;
//land.Info.StreetId= viewModel.Street;
//land.Info.AddressNumber = viewModel.NumberAdress;
//land.Info.OperationType = viewModel.OperationType;

//land.LandArea = viewModel.LandArea;
//land.SpecialLand = viewModel.TypeLand;

//land.Info.DetailsInfo = viewModel.InfoDetails;