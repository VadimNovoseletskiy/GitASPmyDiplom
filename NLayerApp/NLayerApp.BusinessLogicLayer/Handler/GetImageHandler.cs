using System.Linq;
using NLayerApp.BusinessLogicLayer.Models.Images;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class GetImageHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public GetImageHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public GetImageHandler() : this(new UnitOfWork())
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
                    Image = p.Image
                }).FirstOrDefault();
    }
}