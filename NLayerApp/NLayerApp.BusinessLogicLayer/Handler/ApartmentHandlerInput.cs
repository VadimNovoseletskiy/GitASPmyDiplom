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
    public class ApartmentHandlerInput
    {
        private readonly IUnitOfWork unitOfWork;

        public ApartmentHandlerInput(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public ApartmentHandlerInput() : this(new UnitOfWork())
        {
        }

        public void InsertApartment(ApartmentInputParameters parameters)
        {
            Info myInfo = new Info
            {
                RegionId = parameters.Region  ,
                VillageId = parameters.Village,  
                StreetId = parameters.Street,
                NameCaptionLink = parameters.CaptionLink,
                DetailsInfo = parameters.InfoDetails,
                Type = parameters.Type,
                OperationType = parameters.OperationType,
                AddressNumber = parameters.NumberAdress,
                TotalAreaInfo = parameters.TotalArea,
                GrnPrice = parameters.GrnPrice,
                DollarPrice = parameters.DollarPrice,
                FloorMaterialId = parameters.FloorMaterial,
                WallMaterialId = parameters.WallMaterial,
                Apartment = new Apartment
                {
                    ConditionOfApartment = parameters.ConditionOfApartment,
                    TotalFloorApartment = parameters.TotalFloor,
                    FloorApartment = parameters.FloorApartment,
                    LivingAreaApartment = parameters.LivingAreaApartment,
                    KitchenAreaApartment = parameters.KitchenAreaApartment,
                    RoomsApartment = parameters.RoomsApartment,
                    TypeRoom = parameters.RoomType,
                    BathRoomApartment = parameters.BathRoomApartment,
                    BalconyApartment = parameters.BalconyApartment,
                    ReadinessApartment = parameters.ReadinessApartment
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

        }

        public void SaveObject()
        {
            this.unitOfWork.SaveChanges();
        }
    }
}
