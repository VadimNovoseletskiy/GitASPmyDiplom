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
                    InfoId = p.InfoId.Value,
                    fotoName = p.Name,
                    Image = p.Image,
                    IdObject = p.Info.Id
                })
                .ToList<ImageInsertUpdateViewModel>(); 

       //?? 
        public List<ImageInsertUpdateViewModel> FindInfoObject(int? id) =>
            this.unitOfWork.GenericRepository<Picture>()
                .Get()
                .Where(p => p.InfoId == id)
                .Select(p => new ImageInsertUpdateViewModel
                {
                    InfoId = p.InfoId.Value,
                    fotoName = p.Name,
                    Image = p.Image
                    
                   
                })
                .ToList<ImageInsertUpdateViewModel>();


       
        public void InsertImage(ImageParameters parameters)
        {
            Picture myImage=new Picture
            { 
                InfoId = parameters.InfoId,
                Name = parameters.fotoName,
                Image = parameters.Image

            };
            this.unitOfWork.GenericRepository<Picture>().InsertGraph(myImage);
            this.unitOfWork.SaveChanges();
        }
    }
}
