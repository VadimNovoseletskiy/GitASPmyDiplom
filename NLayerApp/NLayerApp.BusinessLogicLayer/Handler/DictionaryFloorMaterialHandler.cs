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
    public class DictionaryFloorMaterialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DictionaryFloorMaterialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DictionaryFloorMaterialHandler() : this(new UnitOfWork())
        {

        }

        public List<FloorMaterialViewModel> GetFloorMaterial() =>
            this.unitOfWork.GenericRepository<FloorMaterial>()
                .Get()
                .Select(p => new FloorMaterialViewModel
                {
                    Id = p.Id,
                    FloorMaterial = p.NameFloorMaterils
                }

                )
                .ToList<FloorMaterialViewModel>();

        public void InsertFloorMaterial(FloorMaterialInputParametrs parametrs)
        {
            FloorMaterial myFloorMaterial = new FloorMaterial {NameFloorMaterils = parametrs.FloorMaterial};
            this.unitOfWork.GenericRepository<FloorMaterial>().InsertGraph(myFloorMaterial);
            this.unitOfWork.SaveChanges();
        }

        public FloorMaterial FindFloorMaterial(object id) =>
            this.unitOfWork.GenericRepository<FloorMaterial>().Find(id);

        public void UpddateFloorMaterial(FloorMaterial floorMaterial)
        {
            this.unitOfWork.GenericRepository<FloorMaterial>().Update(floorMaterial);
            this.unitOfWork.SaveChanges();
        }
    }
}
