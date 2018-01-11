using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class DeleteLandHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteLandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DeleteLandHandler() : this(new UnitOfWork())
        {

        }
        
        public DeleteLandViewModel DeleteFindLand(int ?id) =>
            this.unitOfWork.GenericRepository<Land>()
            .Get()
            .Where(x=>x.Id==id)
            .Select(
                        x=>new DeleteLandViewModel
                        {
                            Id = x.Id,
                            Region = x.Info.RegionId.Value,
                            Village = x.Info.VillageId.Value,
                            Street = x.Info.StreetId.Value,
                            NumberAdress = x.Info.AddressNumber,
                            CadastraNumber = x.CadastralNumber,
                            OperationType = x.Info.OperationType,
                            TypeLand = x.SpecialLand,
                            InfoDetails = x.Info.DetailsInfo,
                            LandArea = x.Info.TotalAreaInfo
                           
                        }
                    )
            .FirstOrDefault();


        public int DeleteFindCommunication(int? id)
        {
            var firstOrDefault = this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(x => x.Id == id)
                .Select(x => x.CommunicationId)
                .FirstOrDefault();
            return (int) firstOrDefault;
        }


        public List<DeleteAllimageViewModel> GetAllDeleteImages(int? id) =>
             this.unitOfWork.GenericRepository<Picture>()
                 .Get()
                 .Where(p => p.InfoId == id)
                 .Select(p => new DeleteAllimageViewModel
                 {
                     IdPicture = p.Id,
                     InfoId = p.InfoId.Value
                 })
                 .ToList<DeleteAllimageViewModel>();



        public void DeleteLand(int id)
        {
            var resultDelImg = GetAllDeleteImages(id);
            foreach (var b in resultDelImg)
            {
               this.unitOfWork.GenericRepository<Picture>().Delete(b.IdPicture);
            }

            int idCommercial = DeleteFindCommunication(id);


            this.unitOfWork.GenericRepository<Land>().Delete(id);
            this.unitOfWork.GenericRepository<Info>().Delete(id);
            this.unitOfWork.GenericRepository<Communication>().Delete(idCommercial);
            this.unitOfWork.SaveChanges();
        }

    }
}


