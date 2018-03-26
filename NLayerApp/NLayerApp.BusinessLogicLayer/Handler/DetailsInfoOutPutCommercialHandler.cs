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
    public class DetailsInfoOutPutCommercialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DetailsInfoOutPutCommercialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DetailsInfoOutPutCommercialHandler() : this(new UnitOfWork())
        {

        }

        public CommercialDetailsViewModel DetailsInfoCommercialFind(int? id) =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Include(x=>x.Pictures)
                .Select(
                    p => new CommercialDetailsViewModel
                    {
                        Id = p.Id,
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
                        TotalArea = p.TotalAreaInfo,
                        GrnPrice = p.GrnPrice,
                        DollarPrice = p.DollarPrice,

                        IdPicture = p.Pictures.Select(i=>i.Id).FirstOrDefault()
                    }
                ).FirstOrDefault();

        public CommercialDetailsViewModel IdOutPutDetailsInfo (int ? id )=>
             this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id
                            && x.Type==PropertyType.Commercial)
                .Include(x=>x.Pictures)
                .Select(
                    p => new CommercialDetailsViewModel
                    {
                        Id = p.Id,
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
                        TotalArea = p.TotalAreaInfo,
                        GrnPrice = p.GrnPrice,
                        DollarPrice = p.DollarPrice,

                        IdPicture = p.Pictures.Select(i=>i.Id).FirstOrDefault()
                        
                    }
                ).FirstOrDefault();


    }
}
