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
    public class HouseHandlerAllOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public HouseHandlerAllOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public HouseHandlerAllOutPut() : this(new UnitOfWork())
        {

        }

        public List<HouseViewModel> GetAllHouse() =>
             this.unitOfWork.GenericRepository<Info>()
                 .Get()
                 .Where(p => p.Type == PropertyType.House)
                 .Select(p => new HouseViewModel
                 {
                     Id = p.Id,
                     CaptionLink = p.NameCaptionLink,
                     Village = p.Village.VillageName,
                     Region = p.Region.RegionName,
                     OperationType = p.OperationType,
                     TypeHouse = p.House.TypeHouse,
                     Floor = p.House.FloorHouse,
                     TotalArea = p.TotalAreaInfo,
                     DollarPrice = p.DollarPrice,
                     GrnPrice = p.GrnPrice,
                     ReadinessHouse = p.House.ReadinessHouse

                 }
                 )
                 .ToList<HouseViewModel>();

    }
}
