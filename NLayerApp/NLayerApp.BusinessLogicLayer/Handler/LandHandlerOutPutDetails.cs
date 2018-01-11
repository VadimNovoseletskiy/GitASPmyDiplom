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
     public class LandHandlerOutPutDetails
    {
        private readonly IUnitOfWork unitOfWork;

        public LandHandlerOutPutDetails(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public LandHandlerOutPutDetails() : this(new UnitOfWork())
        {

        }

        public List<LandDetailsViewModel> GetInformation(int Id)
        {
            List<LandDetailsViewModel> resulst = this.unitOfWork.GenericRepository<Info>().Get()
                .Where(p => p.Type == PropertyType.Land
                        && p.Id == Id
                       )

                .Select(p => new LandDetailsViewModel
                {
                    Id = p.Id,
                    CaptionLink = p.NameCaptionLink,
                    Region = p.Region.RegionName,
                    Village = p.Village.VillageName,
                    DollarPrice = p.DollarPrice,
                    TotalAreaInfo = p.TotalAreaInfo
                }
                        )
                .ToList<LandDetailsViewModel>();

            return resulst;

        }
    }
}
