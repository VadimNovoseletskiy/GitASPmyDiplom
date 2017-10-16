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
    public class WallMaterialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public WallMaterialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public WallMaterialHandler() : this(new UnitOfWork())
        {

        }

        public List<DropDownViewModel> GetWallMaterial()
        {

            List<DropDownViewModel> result = this.unitOfWork.GenericRepository<WallMaterial>()
                .Get()
                .Select(
                    p => new DropDownViewModel
                    {
                        Id = p.Id,
                        Value = p.NameWallMaterils
                    }
                )
                .ToList<DropDownViewModel>();
            return result;
        }
    }
}