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
    public class CommercialHandlerInput
    {
        private readonly IUnitOfWork unitOfWork;

        public CommercialHandlerInput(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public CommercialHandlerInput() : this(new UnitOfWork())
        {
            
        }

        public void InsertCommercial(CommercialInputParameters parameters)
        {
            Info myInfo=new Info
            {
                Region = new Region { RegionName = parameters.Region },
                Village = new Village { VillageName = parameters.Village },
                Street = new Street { StreetName = parameters.Street },
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
                Commercial = new Commercial
                                {
                                    TypeCommercial = parameters.TypeCommercial,
                                    StateCommercial = parameters.StateCommercial,
                                    FloorCommercial = parameters.FloorCommercial,
                                    TotalFloorCommercial = parameters.TotalFloorCommercial,
                                    EffectiveAreaCommercial = parameters.EffectiveAreaCommercial,
                                    LandAreaCommercial = parameters.LandAreaCommercial
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
        }

        public void SaveObject()
        {
            this.unitOfWork.SaveChanges();
        }

    }
}
