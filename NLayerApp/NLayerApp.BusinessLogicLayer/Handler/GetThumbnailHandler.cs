using System.Linq;
using NLayerApp.BusinessLogicLayer.Models.Images;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class GetThumbnailHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public GetThumbnailHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public GetThumbnailHandler() : this(new UnitOfWork())
        {

        }

        public ImageViewModel Execute(int? id) =>
           this.unitOfWork.GenericRepository<Picture>()
               .Get()
               .Where(p => p.Id == id)
               .Select(p => new ImageViewModel
               {
                   Id = p.Id,
                   Name = p.Name,
                   Image = p.Thumbnail
               }).FirstOrDefault();
    }
}
