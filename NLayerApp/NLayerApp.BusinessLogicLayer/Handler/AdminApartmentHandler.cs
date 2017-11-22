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
    public class AdminApartmentHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public AdminApartmentHandler(IUnitOfWork uniOfWork)
        {
            this.unitOfWork = uniOfWork;
        }

        public AdminApartmentHandler()
        {

        }

        public List<AdminApartmentViewModel> GetAllApartment() =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(p => p.Type == PropertyType.Apartment)
                .Select(
                    p => new AdminApartmentViewModel
                    {
                        Id = p.Id,
                        OperationType = p.OperationType,
                        Village = p.Village.VillageName,
                        Street = p.Street.StreetName,
                        AddressNumber = p.AddressNumber,
                        ApartmentNumber = p.Apartment.ApartmentNumber
                        
                    }
                )
                .ToList<AdminApartmentViewModel>();

        public void InsertApartment(ApartmentInputParameters parameters)
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
                Apartment = new Apartment
                {
                    ApartmentNumber = parameters.ApartmentNumber,
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
            this.unitOfWork.SaveChanges();
        }

        public ApartmentInsertUpdateViewModel FindInfoApartment(int? id) =>
            this.unitOfWork
            .GenericRepository<Info>()
            .Get()
            .Where(x => x.Id == id)
            .Select(
                        x => new ApartmentInsertUpdateViewModel
                        {
                            Id = x.Id,
                            Region = x.RegionId.Value,
                            Village = x.VillageId.Value,
                            Street = x.StreetId.Value,
                            NumberAdress = x.AddressNumber,
                            OperationType = x.OperationType,
                           
                            FloorMaterial = x.FloorMaterialId.Value,
                            WallMaterial = x.WallMaterialId.Value,
                            TotalAreaInfo = x.TotalAreaInfo,

                            ApartmentNumber = x.Apartment.ApartmentNumber,
                            ConditionOfApartment = x.Apartment.ConditionOfApartment,
                            RoomsApartment = x.Apartment.RoomsApartment,
                            RoomType = x.Apartment.TypeRoom,
                            ReadinessApartment = x.Apartment.ReadinessApartment,
                            BathRoomApartment = x.Apartment.BathRoomApartment,
                            BalconyApartment = x.Apartment.BalconyApartment,
                            FloorApartment = x.Apartment.FloorApartment,
                            TotalFloor = x.Apartment.TotalFloorApartment,
                            LivingAreaApartment = x.Apartment.LivingAreaApartment,
                            KitchenAreaApartment = x.Apartment.KitchenAreaApartment,

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

                            CaptionLink = x.NameCaptionLink,
                            NameInfo = x.NameInfo,
                            InfoDetails = x.DetailsInfo,
                            InfoPrivat = x.PrivateInfo,

                            GrnPrice = x.GrnPrice,
                            DollarPrice = x.DollarPrice
                        }
                )
                .FirstOrDefault();

        public void UpdateInfoApartment(ApartmentInsertUpdateViewModel viewModel)
        {
            //получил по айдешке запись из бд,
            var info = unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == viewModel.Id)
                .Include(x => x.Apartment)
                .Include(x => x.WallMaterial)
                .Include(x => x.FloorMaterial)
                .Include(x => x.AdditionalEquipment)
                .FirstOrDefault();

            //проставил ей все значения из этого вьюмодела,
            
            info.RegionId = viewModel.Region;
            info.VillageId = viewModel.Village;
            info.StreetId = viewModel.Street;
            info.AddressNumber = viewModel.NumberAdress;
            info.OperationType = viewModel.OperationType;
            info.TotalAreaInfo = viewModel.TotalAreaInfo;

            info.WallMaterialId = viewModel.WallMaterial;
            info.FloorMaterialId = viewModel.FloorMaterial;

            info.Apartment.ApartmentNumber = viewModel.ApartmentNumber;
            info.Apartment.ConditionOfApartment = viewModel.ConditionOfApartment;
            info.Apartment.RoomsApartment = viewModel.RoomsApartment;
            info.Apartment.TypeRoom = viewModel.RoomType;
            info.Apartment.ReadinessApartment = viewModel.ReadinessApartment;
            info.Apartment.BathRoomApartment = viewModel.BathRoomApartment;
            info.Apartment.BalconyApartment = viewModel.BalconyApartment;
            info.Apartment.FloorApartment = viewModel.FloorApartment;
            info.Apartment.TotalFloorApartment = viewModel.TotalFloor;
            info.Apartment.LivingAreaApartment = viewModel.LivingAreaApartment;
            info.Apartment.KitchenAreaApartment = viewModel.KitchenAreaApartment;


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
           
            info.NameCaptionLink = viewModel.CaptionLink;
            info.NameInfo = viewModel.NameInfo;
            info.DetailsInfo = viewModel.InfoDetails;
            info.PrivateInfo = viewModel.InfoPrivat;

            info.GrnPrice = viewModel.GrnPrice;
            info.DollarPrice = viewModel.DollarPrice;



            //проапдейтил запись в бд
            this.unitOfWork.GenericRepository<Info>().Update(info);
            this.unitOfWork.GenericRepository<Apartment>().Update(info.Apartment);
            this.unitOfWork.GenericRepository<WallMaterial>().Update(info.WallMaterial);
            this.unitOfWork.GenericRepository<FloorMaterial>().Update(info.FloorMaterial);
            this.unitOfWork.GenericRepository<AdditionalEquipment>().Update(info.AdditionalEquipment);

            this.unitOfWork.SaveChanges();
        }
    }
}
