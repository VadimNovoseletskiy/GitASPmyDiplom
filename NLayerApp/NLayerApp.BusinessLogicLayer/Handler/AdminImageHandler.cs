using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class AdminImageHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public AdminImageHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork= unitOfWork;
        }

        public AdminImageHandler()
        {

        }

        public List<ImageInsertUpdateViewModel> GetAllImages(int ? id ) =>
            this.unitOfWork.GenericRepository<Picture>()
                .Get()
                .Where(p => p.InfoId == id)
                .Select(p => new ImageInsertUpdateViewModel
                {
                    fotoName = p.Name,
                    Image = p.Image
                })
                .ToList<ImageInsertUpdateViewModel>(); 


        public ImageInsertUpdateViewModel FindInfoObject(int? id) =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(p => p.Id == id)
                .Select(p => new ImageInsertUpdateViewModel
                {
                    Id = p.Id,
                    Village = p.Village.VillageName,
                    Region = p.Region.RegionName,
                    Street = p.Street.StreetName,
                    NumberAdress = p.AddressNumber
                })
                .FirstOrDefault();


       
        public void InsertImage(ImageParameters parameters)
        {
            Picture myImage=new Picture
            { 
                Name = parameters.fotoName,
                Image = parameters.Image

            };
            this.unitOfWork.GenericRepository<Picture>().InsertGraph(myImage);
            this.unitOfWork.SaveChanges();
        }
    }
}
