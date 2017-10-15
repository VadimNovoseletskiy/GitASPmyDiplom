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
                TotalAreaInfo = parameters.TotalAreaInfo,
                GrnPrice = parameters.GrnPrice,
                DollarPrice = parameters.DollarPrice,
                House = new House
                                {
                                    TypeHouse = parameters.TypeHouse,
                                    ConditionOfHouse = parameters.ConditionHouse,
                                    PartHouse = parameters.PartHouse,
                                    FloorHouse = parameters.FloorHouse,
                                    RoomsHouse = parameters.RoomsHouse,
                                    LivingAreaHouse = parameters.LivingAreaHouse,
                                    KitchenAreaHouse = parameters.KitchenAreaHouse,
                                    LandAreaHouse = parameters.LandAreaHouse
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
