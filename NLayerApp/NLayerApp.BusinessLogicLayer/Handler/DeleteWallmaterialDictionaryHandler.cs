using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
     public class DeleteWallmaterialDictionaryHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteWallmaterialDictionaryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DeleteWallmaterialDictionaryHandler() : this(new UnitOfWork())
        {

        }

        public WallMaterial DeleteWallrMaterialDictionaryFind(int? id) =>
            this.unitOfWork
                .GenericRepository<WallMaterial>()
                .Get()
                .FirstOrDefault(x => x.Id == id);

        public void DeleteFindWallMaterialDictionary(int id)
        {
            var info = this.unitOfWork.GenericRepository<Info>().
                Get()
                .Where(x => x.RegionId == id)
                .Include(x => x.House)
                .Include(x => x.Apartment)
                .Include(x => x.Commercial)
                .ToList();
            foreach (var myDelete in info)
            {

                if (myDelete.Type == PropertyType.House)
                {
                    this.unitOfWork.GenericRepository<House>()
                    .Delete(myDelete.House);
                }
                if (myDelete.Type == PropertyType.Apartment)
                {
                    this.unitOfWork.GenericRepository<Apartment>()
                    .Delete(myDelete.Apartment);
                }
                if (myDelete.Type == PropertyType.Commercial)
                {
                    this.unitOfWork.GenericRepository<Commercial>()
                   .Delete(myDelete.Commercial);
                }
                this.unitOfWork.GenericRepository<Info>()
                  .Delete(myDelete);

            }
            var wMaterial = this.unitOfWork
                .GenericRepository<WallMaterial>()
                .Get()
                .FirstOrDefault(x => x.Id == id);
            this.unitOfWork.GenericRepository<WallMaterial>().Delete(wMaterial);

            this.unitOfWork.SaveChanges();
        }
    }
}
