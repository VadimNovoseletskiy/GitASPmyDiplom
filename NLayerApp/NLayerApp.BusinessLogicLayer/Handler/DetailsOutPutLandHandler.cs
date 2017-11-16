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
    public class DetailsOutPutLandHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DetailsOutPutLandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DetailsOutPutLandHandler() : this(new UnitOfWork())
        {

        }

        public LandDetailsInfoViewModel DetailsInfoLandFind(int? id) =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(
                    p => new LandDetailsInfoViewModel
                    {
                        Id = p.Id,
                        Village = p.Village.VillageName,
                        Region = p.Region.RegionName,
                        Street = p.Street.StreetName,
                        OperationType = p.OperationType,

                        Gas = p.Communication.GasCommunications,
                        RailWay = p.Communication.RailWay,
                        CentralSewerage = p.Communication.CentralSewerageCommunications,
                        CentralWater = p.Communication.CentralWaterCommunications,
                        CentralHeating = p.Communication.CentralHeatingCommunications,
                        Electricity = p.Communication.ElectricityCommunications,
                       
                        CaptionLink = p.NameCaptionLink,
                        NameInfo = p.NameInfo,
                        InfoDetails = p.DetailsInfo,
                        LandArea = p.TotalAreaInfo,
                        GrnPrice = p.GrnPrice,
                        DollarPrice = p.DollarPrice
                    }
                )
                .FirstOrDefault();
    }
}
