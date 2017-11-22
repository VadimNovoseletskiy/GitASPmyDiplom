using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;

namespace NLayerApp.BusinessLogicLayer.Handler
{
     public class AdminCommercialHandler
    {
       
            private readonly IUnitOfWork unitOfWork;

            public AdminCommercialHandler(IUnitOfWork uniOfWork)
            {
                this.unitOfWork = uniOfWork;
            }

            public AdminCommercialHandler()
            {

            }

            public List<AdminCommercialViewModel> GetAllCommercial() =>
                this.unitOfWork.GenericRepository<Info>()
                    .Get()
                    .Where(p => p.Type == PropertyType.Commercial)
                    .Select(
                        p => new AdminCommercialViewModel
                        {
                            Id = p.Id,
                            OperationType = p.OperationType,
                            Village = p.Village.VillageName,
                            Street = p.Street.StreetName,
                            AddressNumber = p.AddressNumber,
                            OficeNumber = p.Commercial.OficeNumber
                        }
                    )
                    .ToList<AdminCommercialViewModel>();

            public void InsertCommercial(CommercialInputParameters parameters)
            {
                Info myInfo = new Info
                {
                    RegionId = parameters.Region,
                    VillageId = parameters.Village,
                    StreetId = parameters.Street,
                    NameCaptionLink = parameters.CaptionLink,
                    NameInfo = parameters.NameInfo,
                    DetailsInfo = parameters.InfoDetails,
                    PrivateInfo = parameters.InfoPrivat,
                    Type = parameters.Type,
                    OperationType = parameters.OperationType,
                    AddressNumber = parameters.NumberAdress,
                    TotalAreaInfo = parameters.TotalArea,
                    GrnPrice = parameters.GrnPrice,
                    DollarPrice = parameters.DollarPrice,
                    FloorMaterialId = parameters.FloorMaterial,
                    WallMaterialId = parameters.WallMaterial,
                    Commercial = new Commercial
                    {
                        TypeCommercial = parameters.TypeCommercial,
                        StateCommercial = parameters.StateCommercial,
                        FloorCommercial = parameters.FloorCommercial,
                        TotalFloorCommercial = parameters.TotalFloorCommercial,
                        EffectiveAreaCommercial = parameters.EffectiveAreaCommercial,
                        LandAreaCommercial = parameters.LandAreaCommercial,
                        OficeNumber = parameters.OficeNumber

                    },

                   
                    Communication = new Communication
                    {
                        GasCommunications = parameters.Gas,
                        RailWay = parameters.RailWay,
                        ElectricityCommunications = parameters.Electricity,
                        CentralSewerageCommunications = parameters.CentralSewerage,
                        CentralWaterCommunications = parameters.CentralWater,
                        CentralHeatingCommunications = parameters.CentralHeating,
                        AutonomousSewerageCommunications = parameters.AutonomousSewerage,
                        AutonomousWaterCommunications = parameters.AutonomousWater,
                        AutonomusHeatingCommunications = parameters.CentralHeating
                    },
                    AdditionalEquipment = new AdditionalEquipment
                    {
                        AirConditioningAdditionalEquipment = parameters.Air,
                        BoilerAdditionalEquipment = parameters.Boiler,
                        CableTVadditionalEquipment = parameters.CableTv,
                        FirePlaceAdditionalEquipment = parameters.FirePlace,
                        FurnitureAdditionalEquipment = parameters.Furniture,
                        IntercomAdditionalEquipment = parameters.Intercom,
                        InternetAdditionalEquipment = parameters.Internet,
                        SignalingAdditionalEquipment = parameters.Signaling,
                        SatelliteTVadditionalEquipment = parameters.SatelliteTv,
                        WashingMachineAdditionalEqipment = parameters.WashingMachine,
                        WindowsAdditionalEquipment = parameters.MyWindows,
                        TelephoneAdditionalEqipment = parameters.Telephone
                    }
                };

                this.unitOfWork.GenericRepository<Info>().InsertGraph(myInfo);
                this.unitOfWork.SaveChanges();
            }

            public CommercialInsertUpdateViewModel FindInfoCommercial(int? id) =>
                this.unitOfWork
                .GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(
                            x => new CommercialInsertUpdateViewModel
                            {
                                Id = x.Id,
                                Region = x.RegionId.Value,
                                Village = x.VillageId.Value,
                                Street = x.StreetId.Value,
                                NumberAdress = x.AddressNumber,
                                OperationType = x.OperationType,
                                TotalArea = x.TotalAreaInfo,

                                TypeCommercial = x.Commercial.TypeCommercial,
                                StateCommercial = x.Commercial.StateCommercial,
                                FloorCommercial = x.Commercial.FloorCommercial,
                                TotalFloorCommercial = x.Commercial.TotalFloorCommercial,
                                EffectiveAreaCommercial = x.Commercial.EffectiveAreaCommercial,
                                LandAreaCommercial = x.Commercial.LandAreaCommercial,
                                OficeNumber = x.Commercial.OficeNumber,

                                FloorMaterial = x.FloorMaterialId.Value,
                                WallMaterial = x.WallMaterialId.Value,

                                Boiler = x.AdditionalEquipment.BoilerAdditionalEquipment,
                                Intercom = x.AdditionalEquipment.IntercomAdditionalEquipment,
                                Internet = x.AdditionalEquipment.InternetAdditionalEquipment,
                                CableTv = x.AdditionalEquipment.CableTVadditionalEquipment,
                                FirePlace = x.AdditionalEquipment.FirePlaceAdditionalEquipment,
                                Air = x.AdditionalEquipment.AirConditioningAdditionalEquipment,
                                Furniture = x.AdditionalEquipment.FurnitureAdditionalEquipment,
                                Signaling = x.AdditionalEquipment.SignalingAdditionalEquipment,
                                SatelliteTv = x.AdditionalEquipment.SatelliteTVadditionalEquipment,
                                MyWindows = x.AdditionalEquipment.WindowsAdditionalEquipment,
                                Telephone = x.AdditionalEquipment.TelephoneAdditionalEqipment,
                                WashingMachine = x.AdditionalEquipment.WashingMachineAdditionalEqipment,

                                Gas = x.Communication.GasCommunications,
                                RailWay = x.Communication.RailWay,
                                CentralSewerage = x.Communication.CentralSewerageCommunications,
                                CentralHeating = x.Communication.CentralHeatingCommunications,
                                CentralWater = x.Communication.CentralWaterCommunications,
                                AutonomousSewerage = x.Communication.AutonomousSewerageCommunications,
                                AutonomousWater = x.Communication.AutonomousWaterCommunications,
                                AutonomusHeating = x.Communication.AutonomusHeatingCommunications,
                                Electricity = x.Communication.ElectricityCommunications,

                                CaptionLink = x.NameCaptionLink,
                                NameInfo = x.NameInfo,
                                InfoDetails = x.DetailsInfo,
                                InfoPrivat = x.PrivateInfo,

                                GrnPrice = x.GrnPrice,
                                DollarPrice = x.DollarPrice
                            }
                    )
                    .FirstOrDefault();

            public void UpdateInfoCommercial(CommercialInsertUpdateViewModel viewModel)
            {
                //получил по айдешке запись из бд,
                var info = unitOfWork.GenericRepository<Info>()
                    .Get()
                    .Where(x => x.Id == viewModel.Id)
                    .Include(x => x.Commercial)
                    .Include(x => x.Communication)
                    .Include(x => x.WallMaterial)
                    .Include(x => x.FloorMaterial)
                    .Include(x => x.AdditionalEquipment)
                    .Include(x=>x.Region)
                    .Include(x=>x.Village)
                    .Include(x=>x.Street)
                    .FirstOrDefault();

                //проставил ей все значения из этого вьюмодела,
                
                info.RegionId = viewModel.Region;
                info.VillageId = viewModel.Village;
                info.StreetId = viewModel.Street;
                info.AddressNumber = viewModel.NumberAdress;
                info.OperationType = viewModel.OperationType;
                info.TotalAreaInfo = viewModel.TotalArea;

                info.Commercial.TypeCommercial=viewModel.TypeCommercial;
                info.Commercial.StateCommercial=viewModel.StateCommercial;
                info.Commercial.FloorCommercial=viewModel.FloorCommercial;
                info.Commercial.TotalFloorCommercial=viewModel.TotalFloorCommercial;
                info.Commercial.EffectiveAreaCommercial=viewModel.EffectiveAreaCommercial;
                info.Commercial.LandAreaCommercial=viewModel.LandAreaCommercial;
                info.Commercial.OficeNumber = viewModel.OficeNumber;
                
                info.WallMaterialId = viewModel.WallMaterial;
                info.FloorMaterialId = viewModel.FloorMaterial;

                info.AdditionalEquipment.BoilerAdditionalEquipment = viewModel.Boiler;
                info.AdditionalEquipment.IntercomAdditionalEquipment = viewModel.Intercom;
                info.AdditionalEquipment.InternetAdditionalEquipment = viewModel.Internet;
                info.AdditionalEquipment.CableTVadditionalEquipment = viewModel.CableTv;
                info.AdditionalEquipment.FirePlaceAdditionalEquipment = viewModel.FirePlace;
                info.AdditionalEquipment.AirConditioningAdditionalEquipment = viewModel.Air;
                info.AdditionalEquipment.FurnitureAdditionalEquipment = viewModel.Furniture;
                info.AdditionalEquipment.SignalingAdditionalEquipment = viewModel.Signaling;
                info.AdditionalEquipment.SatelliteTVadditionalEquipment = viewModel.SatelliteTv;
                info.AdditionalEquipment.WindowsAdditionalEquipment = viewModel.MyWindows;
                info.AdditionalEquipment.TelephoneAdditionalEqipment = viewModel.Telephone;
                info.AdditionalEquipment.WashingMachineAdditionalEqipment = viewModel.WashingMachine;
               
                info.Communication.GasCommunications = viewModel.Gas;
                info.Communication.CentralHeatingCommunications = viewModel.CentralHeating;
                info.Communication.CentralSewerageCommunications = viewModel.CentralSewerage;
                info.Communication.CentralWaterCommunications = viewModel.CentralWater;
                info.Communication.ElectricityCommunications = viewModel.Electricity;
                info.Communication.RailWay = viewModel.RailWay;
                info.Communication.AutonomousSewerageCommunications = viewModel.AutonomousSewerage;
                info.Communication.AutonomousWaterCommunications = viewModel.AutonomousWater;
                info.Communication.AutonomusHeatingCommunications = viewModel.AutonomusHeating;

                info.NameCaptionLink = viewModel.CaptionLink;
                info.NameInfo = viewModel.NameInfo;
                info.DetailsInfo = viewModel.InfoDetails;
                info.PrivateInfo = viewModel.InfoPrivat;

                info.GrnPrice = viewModel.GrnPrice;
                info.DollarPrice = viewModel.DollarPrice;

                //проапдейтил запись в бд
                this.unitOfWork.GenericRepository<Info>().Update(info);
                this.unitOfWork.GenericRepository<Commercial>().Update(info.Commercial);
                this.unitOfWork.GenericRepository<Communication>().Update(info.Communication);
                this.unitOfWork.GenericRepository<WallMaterial>().Update(info.WallMaterial);
                this.unitOfWork.GenericRepository<FloorMaterial>().Update(info.FloorMaterial);
                this.unitOfWork.GenericRepository<AdditionalEquipment>().Update(info.AdditionalEquipment);
                this.unitOfWork.GenericRepository<Region>().Update(info.Region);
                this.unitOfWork.GenericRepository<Village>().Update(info.Village);
                this.unitOfWork.GenericRepository<Street>().Update(info.Street);


                this.unitOfWork.SaveChanges();
            }
        }
}
