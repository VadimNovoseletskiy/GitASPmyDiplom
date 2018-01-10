using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using System.Data.Entity;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class AdminLandHandler
    {
       
        private readonly IUnitOfWork unitOfWork;

        public AdminLandHandler(IUnitOfWork uniOfWork)
        {
            this.unitOfWork = uniOfWork;
        }

        public AdminLandHandler()
        {
            
        }

        public List<AdminLandViewModel> GetAllLand() =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(p => p.Type == PropertyType.Land)
                .Select(
                    p => new AdminLandViewModel
                    {
                        Id = p.Id,
                        OperationType = p.OperationType,
                        Village = p.Village.VillageName,
                        Street = p.Street.StreetName,
                        AddressNumber = p.AddressNumber,
                        CadastraNumber = p.Land.CadastralNumber
                    }
                )
                .ToList<AdminLandViewModel>();

        public void InsertLand(LandInputParameters parameters)
        {
            Info myInfo = new Info
            {
                RegionId = parameters.Region ,
                VillageId = parameters.Village ,
                StreetId = parameters.Street ,
                NameCaptionLink = parameters.CaptionLink,
                DetailsInfo = parameters.InfoDetails,
                Type = parameters.Type,
                OperationType = parameters.OperationType,
                AddressNumber = parameters.NumberAdress,
                TotalAreaInfo = parameters.TotalArea,
                GrnPrice = parameters.GrnPrice,
                DollarPrice = parameters.DollarPrice,
                Land = new Land
                {
                    SpecialLand = parameters.TypeLand,
                    CadastralNumber = parameters.CadastraNumber
                },
                Communication = new Communication
                {
                    GasCommunications = parameters.Gas,
                    RailWay = parameters.RailWay,
                    ElectricityCommunications = parameters.Electricity,
                    CentralSewerageCommunications = parameters.CentralSewerage,
                    CentralWaterCommunications = parameters.CentralWater,
                    CentralHeatingCommunications = parameters.CentralHeating,
                    AutonomusHeatingCommunications = parameters.CentralHeating
                }
            };

            this.unitOfWork.GenericRepository<Info>().InsertGraph(myInfo);
            this.unitOfWork.SaveChanges();
        }

        public LandInsertUpdateViewModel FindInfoLand(int ?id) =>
            this.unitOfWork
            .GenericRepository<Info>()
            .Get()
            .Where( x => x.Id == id)
            .Select(
                        x=>new LandInsertUpdateViewModel
                        {
                           Id = x.Id,
                           Region = x.RegionId.Value,
                           Village = x.VillageId.Value,
                           Street = x.StreetId.Value,
                           NumberAdress = x.AddressNumber,
                           OperationType = x.OperationType,
                           TypeLand = x.Land.SpecialLand,
                           TotalArea= x.TotalAreaInfo,
                           CadastraNummber = x.Land.CadastralNumber,
                           Gas = x.Communication.GasCommunications,
                           RailWay = x.Communication.RailWay,
                           CentralSewerage = x.Communication.CentralSewerageCommunications,
                           CentralHeating = x.Communication.CentralHeatingCommunications,
                           CentralWater = x.Communication.CentralWaterCommunications,
                           Electricity = x.Communication.ElectricityCommunications,
                           CaptionLink = x.NameCaptionLink,
                           InfoDetails = x.DetailsInfo,
                           GrnPrice = x.GrnPrice,
                           DollarPrice = x.DollarPrice
                        }
                ) .FirstOrDefault();

        public void UpdateInfoLand(LandInsertUpdateViewModel viewModel)
        {
                //получил по айдешке запись из бд,
            var info = unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == viewModel.Id)
                .Include(x => x.Land)
                .Include(x => x.Communication)
                .FirstOrDefault();

                //проставил ей все значения из этого вьюмодела,

            info.RegionId = viewModel.Region;
            info.VillageId = viewModel.Village;
            info.StreetId = viewModel.Street;
            info.AddressNumber = viewModel.NumberAdress;
            info.Land.CadastralNumber = viewModel.CadastraNummber;
            info.OperationType = viewModel.OperationType;
            info.TotalAreaInfo = viewModel.TotalArea;

            info.TotalAreaInfo = viewModel.TotalArea;
            info.Land.SpecialLand = viewModel.TypeLand;

            info.Communication.GasCommunications = viewModel.Gas;
            info.Communication.CentralHeatingCommunications = viewModel.CentralHeating;
            info.Communication.CentralSewerageCommunications = viewModel.CentralSewerage;
            info.Communication.CentralWaterCommunications = viewModel.CentralWater;
            info.Communication.ElectricityCommunications = viewModel.Electricity;
            info.Communication.RailWay = viewModel.RailWay;

            info.NameCaptionLink = viewModel.CaptionLink;
            info.DetailsInfo = viewModel.InfoDetails;

            info.GrnPrice = viewModel.GrnPrice;
            info.DollarPrice = viewModel.DollarPrice;



                //проапдейтил запись в бд
            this.unitOfWork.GenericRepository<Info>().Update(info);
            this.unitOfWork.GenericRepository<Land>().Update(info.Land);
            this.unitOfWork.GenericRepository<Communication>().Update(info.Communication);
            this.unitOfWork.SaveChanges();
        }
    }


    
}
