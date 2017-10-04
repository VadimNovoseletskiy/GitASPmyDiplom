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

        void GetInformation(LandSearchParameters parameters)
        {
            this.unitOfWork.GenericRepository<Info>().Get().Where(p => p.Type == PropertyType.Land
                                                            && p.Region.RegionName==parameters.VillageRegion        
                                                            || p.Land.SpecialLand == SpecialTypeLand.Commercial
                                                            || p.Land.SpecialLand == SpecialTypeLand.Agricultural
                                                            || p.Land.SpecialLand == SpecialTypeLand.Individual
                                                            && p.DollarPrice > parameters.CostFrom
                                                            && p.DollarPrice< parameters.CostTo
                                                            ).Select(IQueryable<>)
                                                          


        }
    }
}
