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
    public class SearchIdHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public SearchIdHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork=unitOfWork;
        }

        public SearchIdHandler():this(new UnitOfWork())
        {

        }

        public SearchIdViewModel TypeMyObjectFind(int? id) =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(
                    p => new SearchIdViewModel
                    {
                        Id = p.Id,
                        MyType = p.Type
                    }
                )
                .FirstOrDefault();

        public TotalObjectViewModel DetailsInfoObjectFind(int? id) =>
            this.unitOfWork
                .GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(
                    p => new TotalObjectViewModel
                    {
                        Id = p.Id,
                        MyType = p.Type,
                        Village = p.Village.VillageName,
                        Region = p.Region.RegionName,
                        Street = p.Street.StreetName,
                        OperationType = p.OperationType,

                        FloorMaterial = p.FloorMaterial.NameFloorMaterils,
                        WallMaterial = p.WallMaterial.NameWallMaterils,
                        TotalAreaInfo = p.TotalAreaInfo,

                        ConditionOfApartment = p.Apartment.ConditionOfApartment,
                        RoomsApartment = p.Apartment.RoomsApartment,
                        RoomType = p.Apartment.TypeRoom,
                        ReadinessApartment = p.Apartment.ReadinessApartment,
                        BathRoomApartment = p.Apartment.BathRoomApartment,
                        BalconyApartment = p.Apartment.BalconyApartment,
                        FloorApartment = p.Apartment.FloorApartment,
                        TotalFloor = p.Apartment.TotalFloorApartment,
                        LivingAreaApartment = p.Apartment.LivingAreaApartment,
                        KitchenAreaApartment = p.Apartment.KitchenAreaApartment,

                        Boiler = p.AdditionalEquipment.BoilerAdditionalEquipment,
                        Intercom = p.AdditionalEquipment.IntercomAdditionalEquipment,
                        Internet = p.AdditionalEquipment.InternetAdditionalEquipment,
                        CableTv = p.AdditionalEquipment.CableTVadditionalEquipment,
                        FirePlace = p.AdditionalEquipment.FirePlaceAdditionalEquipment,
                        Air = p.AdditionalEquipment.AirConditioningAdditionalEquipment,
                        Furniture = p.AdditionalEquipment.FurnitureAdditionalEquipment,
                        Signaling = p.AdditionalEquipment.SignalingAdditionalEquipment,
                        SatelliteTv = p.AdditionalEquipment.SatelliteTVadditionalEquipment,
                        MyWindows = p.AdditionalEquipment.WindowsAdditionalEquipment,
                        Telephone = p.AdditionalEquipment.TelephoneAdditionalEqipment,
                        WashingMachine = p.AdditionalEquipment.WashingMachineAdditionalEqipment,

                        CaptionLink = p.NameCaptionLink,
                        InfoDetails = p.DetailsInfo,
                        GrnPrice = p.GrnPrice,
                        DollarPrice = p.DollarPrice
                    }
                )
                .FirstOrDefault();

        public TotalObjectViewModel DetailsInfoHouseFind(int? id) =>
        this.unitOfWork.GenericRepository<Info>()
        .Get()
        .Where(x => x.Id == id)
        .Select(
            p => new TotalObjectViewModel
            {
                Id = p.Id,
                MyType = p.Type,
                Village = p.Village.VillageName,
                Region = p.Region.RegionName,
                Street = p.Street.StreetName,
                OperationType = p.OperationType,

                FloorMaterial = p.FloorMaterial.NameFloorMaterils,
                WallMaterial = p.WallMaterial.NameWallMaterils,
                TotalAreaInfo = p.TotalAreaInfo,

                TypeHouse = p.House.TypeHouse,
                PartHouse = p.House.PartHouse,

                ConditionHouse = p.House.ConditionHouse,
                RoomsHouse = p.House.RoomsHouse,
                FloorHouse = p.House.FloorHouse,
                LivingAreaHouse = p.House.LivingAreaHouse,
                KitchenAreaHouse = p.House.KitchenAreaHouse,
                LandAreaHouse = p.House.LandAreaHouse,
                ReadinessHouse = p.House.ReadinessHouse,

                Boiler = p.AdditionalEquipment.BoilerAdditionalEquipment,
                Intercom = p.AdditionalEquipment.IntercomAdditionalEquipment,
                Internet = p.AdditionalEquipment.InternetAdditionalEquipment,
                CableTv = p.AdditionalEquipment.CableTVadditionalEquipment,
                FirePlace = p.AdditionalEquipment.FirePlaceAdditionalEquipment,
                Air = p.AdditionalEquipment.AirConditioningAdditionalEquipment,
                Furniture = p.AdditionalEquipment.FurnitureAdditionalEquipment,
                Signaling = p.AdditionalEquipment.SignalingAdditionalEquipment,
                SatelliteTv = p.AdditionalEquipment.SatelliteTVadditionalEquipment,
                MyWindows = p.AdditionalEquipment.WindowsAdditionalEquipment,
                Telephone = p.AdditionalEquipment.TelephoneAdditionalEqipment,
                WashingMachine = p.AdditionalEquipment.WashingMachineAdditionalEqipment,

                BahtHouse = p.House.BahtHouseOutBuilding,
                Swimming = p.House.SwimmingOutBuildings,
                Garage = p.House.GarageOutBuildings,
                Well = p.House.WellOutBuildings,
                Well1 = p.House.Well1OutBuildings,
                SummerKitchen = p.House.SummerKitchenOutBuildings,
                WorkShop = p.House.WorkShopOutBuildings,
                Barn = p.House.BarnOutBuildings,
                GreenHouse = p.House.GreenHouseOutBuildings,

                Gas = p.Communication.GasCommunications,
                RailWay = p.Communication.RailWay,
                CentralSewerage = p.Communication.CentralSewerageCommunications,
                CentralWater = p.Communication.CentralWaterCommunications,
                CentralHeating = p.Communication.CentralHeatingCommunications,
                Electricity = p.Communication.ElectricityCommunications,
                AutonomousSewerage = p.Communication.AutonomousSewerageCommunications,
                AutonomusHeating = p.Communication.AutonomusHeatingCommunications,
                AutonomousWater = p.Communication.AutonomousWaterCommunications,

                CaptionLink = p.NameCaptionLink,
                InfoDetails = p.DetailsInfo,
                GrnPrice = p.GrnPrice,
                DollarPrice = p.DollarPrice
            }
        )
        .FirstOrDefault();

        public TotalObjectViewModel DetailsInfoCommercialFind(int? id) =>
           this.unitOfWork.GenericRepository<Info>()
               .Get()
               .Where(x => x.Id == id)
               .Select(
                   p => new TotalObjectViewModel
                   {
                       Id = p.Id,
                       MyType = p.Type,
                       Village = p.Village.VillageName,
                       Region = p.Region.RegionName,
                       Street = p.Street.StreetName,
                       OperationType = p.OperationType,

                       TypeCommercial = p.Commercial.TypeCommercial,
                       StateCommercial = p.Commercial.StateCommercial,
                       FloorCommercial = p.Commercial.FloorCommercial,
                       TotalFloorCommercial = p.Commercial.TotalFloorCommercial,
                       EffectiveAreaCommercial = p.Commercial.EffectiveAreaCommercial,
                       LandAreaCommercial = p.Commercial.EffectiveAreaCommercial,

                       FloorMaterial = p.FloorMaterial.NameFloorMaterils,
                       WallMaterial = p.WallMaterial.NameWallMaterils,

                       Boiler = p.AdditionalEquipment.BoilerAdditionalEquipment,
                       Intercom = p.AdditionalEquipment.IntercomAdditionalEquipment,
                       Internet = p.AdditionalEquipment.InternetAdditionalEquipment,
                       CableTv = p.AdditionalEquipment.CableTVadditionalEquipment,
                       FirePlace = p.AdditionalEquipment.FirePlaceAdditionalEquipment,
                       Air = p.AdditionalEquipment.AirConditioningAdditionalEquipment,
                       Furniture = p.AdditionalEquipment.FurnitureAdditionalEquipment,
                       Signaling = p.AdditionalEquipment.SignalingAdditionalEquipment,
                       SatelliteTv = p.AdditionalEquipment.SatelliteTVadditionalEquipment,
                       MyWindows = p.AdditionalEquipment.WindowsAdditionalEquipment,
                       Telephone = p.AdditionalEquipment.TelephoneAdditionalEqipment,
                       WashingMachine = p.AdditionalEquipment.WashingMachineAdditionalEqipment,

                       Gas = p.Communication.GasCommunications,
                       RailWay = p.Communication.RailWay,
                       CentralSewerage = p.Communication.CentralSewerageCommunications,
                       CentralWater = p.Communication.CentralWaterCommunications,
                       CentralHeating = p.Communication.CentralHeatingCommunications,
                       Electricity = p.Communication.ElectricityCommunications,
                       AutonomousSewerage = p.Communication.AutonomousSewerageCommunications,
                       AutonomusHeating = p.Communication.AutonomusHeatingCommunications,
                       AutonomousWater = p.Communication.AutonomousWaterCommunications,

                       CaptionLink = p.NameCaptionLink,
                       InfoDetails = p.DetailsInfo,
                       TotalAreaInfo = p.TotalAreaInfo,
                       GrnPrice = p.GrnPrice,
                       DollarPrice = p.DollarPrice
                   }
               ).FirstOrDefault();


        public TotalObjectViewModel DetailsInfoLandFind(int? id) =>
           this.unitOfWork.GenericRepository<Info>()
               .Get()
               .Where(x => x.Id == id)
               .Select(
                   p => new TotalObjectViewModel
                   {
                       Id = p.Id,
                       MyType = p.Type,
                       Village = p.Village.VillageName,
                       Region = p.Region.RegionName,
                       Street = p.Street.StreetName,
                       OperationType = p.OperationType,
                       TypeLand = p.Land.SpecialLand,

                       Gas = p.Communication.GasCommunications,
                       RailWay = p.Communication.RailWay,
                       CentralSewerage = p.Communication.CentralSewerageCommunications,
                       CentralWater = p.Communication.CentralWaterCommunications,
                       CentralHeating = p.Communication.CentralHeatingCommunications,
                       Electricity = p.Communication.ElectricityCommunications,

                       CaptionLink = p.NameCaptionLink,
                       InfoDetails = p.DetailsInfo,
                       LandArea = p.TotalAreaInfo,
                       GrnPrice = p.GrnPrice,
                       DollarPrice = p.DollarPrice
                   }
               )
               .FirstOrDefault();


    }
}
