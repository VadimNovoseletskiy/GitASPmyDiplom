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
    public class LandHandlerAllOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public LandHandlerAllOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public LandHandlerAllOutPut() : this(new UnitOfWork())
        {

        }

        public List<LandViewModel> GetAllInformation()
        {
            List<LandViewModel> resulst = this.unitOfWork.GenericRepository<Info>().Get()
                .Where(p => p.Type == PropertyType.Land)

                .Select(p => new LandViewModel
                {
                    Id = p.Id,
                    CaptionLink = p.NameCaptionLink,
                    OperationType = p.OperationType,
                    Region = p.Region.RegionName,
                    Village = p.Village.VillageName,
                    DollarPrice = p.DollarPrice,
                    CadastraNumber = p.Land.CadastralNumber,
                    TotalAreaInfo = p.TotalAreaInfo
                }
                        )
                .ToList<LandViewModel>();

            return resulst;

        }
    }
}
