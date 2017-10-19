
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
    public class HouseHandlerInput
    {
        private readonly IUnitOfWork unitOfWork;

        public HouseHandlerInput(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public HouseHandlerInput() : this(new UnitOfWork())
        {
        }

        public void InsertHouse(HouseInputParameters parameters)
        {
            Info myInfo=new Info
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

            this.unitOfWork.GenericRepository<Info>().InsertPhoto(myInfo);
            this.unitOfWork.SaveChanges();
        }

       

    }
}
