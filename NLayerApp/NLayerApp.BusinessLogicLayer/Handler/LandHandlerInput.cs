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
    public class LandHandlerInput
    {
        private readonly IUnitOfWork unitOfWork;

        public LandHandlerInput(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public LandHandlerInput() : this(new UnitOfWork())
        {
        }

        public void InsertLand(LandInputParameters parameters)
        {
            Info myInfo=new Info
            {
                Region = new Region { RegionName = parameters.Region},
                Village = new Village { VillageName = parameters.Village},
                Street = new Street { StreetName = parameters.Street},
                NameCaptionLink = parameters.CaptionLink,
                NameInfo = parameters.NameInfo,
                DetailsInfo = parameters.InfoDetails,
                PrivateInfo = parameters.InfoPrivat,
                Type = parameters.Type,
                OperationType = parameters.OperationType,
                AddressNumber = parameters.NumberAdress,
                TotalAreaInfo = parameters.LandArea,
                GrnPrice = parameters.GrnPrice,
                DollarPrice = parameters.DollarPrice,
                Land= new Land { SpecialLand = parameters.TypeLand,
                                    LandArea = parameters.LandArea},
            };

            this.unitOfWork.GenericRepository<Info>().InsertPhoto(myInfo);
            
        }

        public void SaveObject()
        {
            this.unitOfWork.SaveChanges();
        }

    }
}
