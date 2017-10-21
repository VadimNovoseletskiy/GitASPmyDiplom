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
    public class DictionaryWallMaterialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DictionaryWallMaterialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DictionaryWallMaterialHandler() : this(new UnitOfWork())
        {
        }

        public List<WallMaterialViewModel> GetWallMaterial() =>
            this.unitOfWork.GenericRepository<WallMaterial>()
                .Get()
                .Select(
                    p => new WallMaterialViewModel
                    {
                        Id = p.Id,
                        WallMaterial = p.NameWallMaterils
                    }
                )
                .ToList<WallMaterialViewModel>();

        public void InsertWallMaterial(WallMaterialInputParemeters paremeters)
        {
            WallMaterial myMaterial=new WallMaterial {NameWallMaterils = paremeters.WallMaterial};
            this.unitOfWork.GenericRepository<WallMaterial>().InsertGraph(myMaterial);
            this.unitOfWork.SaveChanges();
        }

        public WallMaterial FindWallMaterial(object id)=>
            this.unitOfWork.GenericRepository<WallMaterial>().Find(id);

        public void UpdateWallMaterial(WallMaterial wallMaterial)
        {
            this.unitOfWork.GenericRepository<WallMaterial>().Update(wallMaterial);
            this.unitOfWork.SaveChanges();
        }


    }
}
