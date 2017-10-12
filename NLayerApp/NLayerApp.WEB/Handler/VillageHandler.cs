using System.Collections.Generic;
using System.Linq;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Models;

namespace NLayerApp.WEB.Handler
{
    public class VillageHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public VillageHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public VillageHandler() : this(new UnitOfWork())
        {
        }



        public List<DropDownViewModel> GetVillage() =>
            this.unitOfWork.GenericRepository<Village>()
                .Get()
                .Select(
                    p => new DropDownViewModel
                    {
                        Id = p.Id,
                        Value = p.VillageName
                    }
                )
                .ToList();
    }
}
