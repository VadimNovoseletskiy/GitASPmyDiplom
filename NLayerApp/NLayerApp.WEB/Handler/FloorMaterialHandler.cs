using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Models;

namespace NLayerApp.WEB.Handler
{
    public class FloorMaterialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public FloorMaterialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public FloorMaterialHandler() : this(new UnitOfWork())
        {
        }

        public List<DropDownViewModel> GetFloorMaterial()
        {
            List<DropDownViewModel> result =
                this.unitOfWork.GenericRepository<FloorMaterial>()
                    .Get()
                    .Select(p => new DropDownViewModel
                        {
                            Id = p.Id,
                            Value = p.NameFloorMaterils

                        }
                    )
                    .ToList<DropDownViewModel>();
            return result;
        }
    }
}