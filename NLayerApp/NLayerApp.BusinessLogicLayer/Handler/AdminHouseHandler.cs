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
    public class AdminHouseHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public AdminHouseHandler(IUnitOfWork uniOfWork)
        {
            this.unitOfWork = uniOfWork;
        }

        public AdminHouseHandler()
        {

        }

        public List<AdminHouseViewModel> GetAllHouse() =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(p => p.Type == PropertyType.House)
                .Select(
                    p => new AdminHouseViewModel
                    {
                        Id = p.Id,
                        OperationType = p.OperationType,
                        Village = p.Village.VillageName,
                        Street = p.Street.StreetName,
                        AddressNumber = p.AddressNumber
                    }
                )
                .ToList<AdminHouseViewModel>();

        public void InsertHouse(HouseInputParameters parameters)
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
                TotalAreaInfo = parameters.TotalAreaInfo,
                GrnPrice = parameters.GrnPrice,
                DollarPrice = parameters.DollarPrice,
                FloorMaterialId = parameters.FloorMaterial,
                WallMaterialId = parameters.WallMaterial,
                House = new House
                {
                    TypeHouse = parameters.TypeHouse,
                    ConditionHouse = parameters.ConditionHouse,
                    PartHouse = parameters.PartHouse,
                    ReadinessHouse=parameters.ReadinessHouse,
                    FloorHouse = parameters.FloorHouse,
                    RoomsHouse = parameters.RoomsHouse,
                    LivingAreaHouse = parameters.LivingAreaHouse,
                    KitchenAreaHouse = parameters.KitchenAreaHouse,
                    LandAreaHouse = parameters.LandAreaHouse,

                    BarnOutBuildings = parameters.Barn,
                    BahtHouseOutBuilding = parameters.BahtHouse,
                    SwimmingOutBuildings = parameters.Swimming,
                    GarageOutBuildings = parameters.Garage,
                    WellOutBuildings = parameters.Well,
                    Well1OutBuildings = parameters.Well1,
                    SummerKitchenOutBuildings = parameters.SummerKitchen,
                    WorkShopOutBuildings = parameters.WorkShop,
                    GreenHouseOutBuildings = parameters.GreenHouse
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

        public HouseInsertUpdateViewModel FindInfoHouse(int? id) =>
            this.unitOfWork
            .GenericRepository<Info>()
            .Get()
            .Where(x => x.Id == id)
            .Select(
                        x => new HouseInsertUpdateViewModel
                        {
                            Id = x.Id,
                            Region = x.RegionId.Value,
                            Village = x.VillageId.Value,
                            Street = x.StreetId.Value,
                            NumberAdress = x.AddressNumber,
                            OperationType = x.OperationType,
                            TypeHouse = x.House.TypeHouse,
                            PartHouse= x.House.PartHouse,
                            ReadinessHouse = x.House.ReadinessHouse,
                            ConditionHouse = x.House.ConditionHouse,
                            RoomsHouse = x.House.RoomsHouse,
                            FloorHouse = x.House.FloorHouse,
                            FloorMaterial = x.FloorMaterialId.Value,
                            WallMaterial = x.WallMaterialId.Value,
                            TotalAreaInfo = x.TotalAreaInfo,

                            LivingAreaHouse = x.House.LivingAreaHouse,
                            KitchenAreaHouse = x.House.KitchenAreaHouse,
                            LandAreaHouse = x.House.LandAreaHouse,

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
                            BahtHouse=x.House.BahtHouseOutBuilding,
                            Swimming = x.House.SwimmingOutBuildings,
                            Garage = x.House.GarageOutBuildings,
                            Well = x.House.WellOutBuildings,
                            Well1 = x.House.Well1OutBuildings,
                            SummerKitchen = x.House.SummerKitchenOutBuildings,
                            WorkShop = x.House.WorkShopOutBuildings,
                            Barn = x.House.BarnOutBuildings,
                            GreenHouse = x.House.GreenHouseOutBuildings,

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

        public void UpdateInfoHouse(HouseInsertUpdateViewModel viewModel)
        {
            //получил по айдешке запись из бд,
            var info = unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == viewModel.Id)
                .Include(x => x.House)
                .Include(x => x.Communication)
                .Include(x=>x.WallMaterial)
                .Include(x=>x.FloorMaterial)
                .Include(x=>x.AdditionalEquipment)
                .FirstOrDefault();

            //проставил ей все значения из этого вьюмодела,

            info.RegionId = viewModel.Region;
            info.VillageId = viewModel.Village;
            info.StreetId = viewModel.Street;
            info.AddressNumber = viewModel.NumberAdress;
            info.OperationType = viewModel.OperationType;
            info.TotalAreaInfo = viewModel.TotalAreaInfo;

            info.House.TypeHouse = viewModel.TypeHouse;
            info.House.PartHouse = viewModel.PartHouse;
            info.House.ConditionHouse = viewModel.ConditionHouse;
            info.House.RoomsHouse = viewModel.RoomsHouse;
            info.House.FloorHouse = viewModel.FloorHouse;
            info.House.LivingAreaHouse = viewModel.LivingAreaHouse;
            info.House.KitchenAreaHouse = viewModel.KitchenAreaHouse;
            info.House.LandAreaHouse = viewModel.LandAreaHouse;
            info.House.ReadinessHouse = viewModel.ReadinessHouse;

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

            info.House.BahtHouseOutBuilding = viewModel.BahtHouse;
            info.House.SwimmingOutBuildings = viewModel.Swimming;
            info.House.GarageOutBuildings = viewModel.Garage;
            info.House.WellOutBuildings = viewModel.Well;
            info.House.Well1OutBuildings = viewModel.Well1;
            info.House.SummerKitchenOutBuildings = viewModel.SummerKitchen;
            info.House.WorkShopOutBuildings = viewModel.WorkShop;
            info.House.BarnOutBuildings = viewModel.Barn;
            info.House.GreenHouseOutBuildings = viewModel.GreenHouse;

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
            this.unitOfWork.GenericRepository<House>().Update(info.House);
            this.unitOfWork.GenericRepository<Communication>().Update(info.Communication);
            this.unitOfWork.GenericRepository<WallMaterial>().Update(info.WallMaterial);
            this.unitOfWork.GenericRepository<FloorMaterial>().Update(info.FloorMaterial);
            this.unitOfWork.GenericRepository<AdditionalEquipment>().Update(info.AdditionalEquipment);

            this.unitOfWork.SaveChanges();
        }
    }
}
