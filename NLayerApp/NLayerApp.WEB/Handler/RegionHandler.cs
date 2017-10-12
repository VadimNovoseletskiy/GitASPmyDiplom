using System.Collections.Generic;
using System.Linq;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Models;

namespace NLayerApp.WEB.Handler
{
    public class RegionHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public RegionHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public RegionHandler() : this(new UnitOfWork())
        {

        }

        public List<DropDownViewModel> GetRegion()
        {

            List<DropDownViewModel> result= this.unitOfWork.GenericRepository<Region>()
                .Get()
                .Select(
                    p => new DropDownViewModel
                    {
                        Id = p.Id,
                        Value = p.RegionName
                    }
                )
                .ToList<DropDownViewModel>();
            return result;
        }
    }
}
