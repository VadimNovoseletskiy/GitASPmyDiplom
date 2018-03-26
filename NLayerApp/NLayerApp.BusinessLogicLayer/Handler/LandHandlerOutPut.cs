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
    public class LandHandlerOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public LandHandlerOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public LandHandlerOutPut() : this(new UnitOfWork())
        {
            
        }

        public List<LandViewModel> GetInformation(LandSearchParameters parameters)
        {
            List<LandViewModel> resulst = this.unitOfWork.GenericRepository<Info>().Get()
                .Where(p => p.Type == PropertyType.Land
                        && p.Region.Id == parameters.Region
                        && p.Village.Id == parameters.Village
                        && p.DollarPrice <= parameters.CostTo
                        && p.Land.SpecialLand == parameters.SpecialLand)
                        
                .Select( p=>new LandViewModel
                                                {
                                                    Id    = p.Id,
                                                    CaptionLink = p.NameCaptionLink,
                                                    OperationType = p.OperationType,
                                                    Region = p.Region.RegionName,
                                                    Village = p.Village.VillageName,
                                                    DollarPrice = p.DollarPrice,
                                                    CadastraNumber= p.Land.CadastralNumber,
                                                    TotalAreaInfo = p.TotalAreaInfo,

                                                    IdPicture = p.Pictures.Select(i=>i.Id).FirstOrDefault()
                                                } 
                        )
                .ToList<LandViewModel>();

                return resulst;

        }
    }
}
