using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageResizer;
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
            this.unitOfWork = unitOfWork;
        }

        public AdminImageHandler()
        {

        }

        public List<ImageInsertUpdateViewModel> GetAllImages(int? id) =>
            this.unitOfWork.GenericRepository<Picture>()
                .Get()
                .Where(p => p.InfoId == id)
                .Select(p => new ImageInsertUpdateViewModel
                {
                    IdPicture = p.Id,
                    InfoId = p.InfoId.Value,
                    fotoName = p.Name,
                    Image = p.Image,

                })
                .ToList<ImageInsertUpdateViewModel>();

        //?? 
        public List<ImageInsertUpdateViewModel> FindInfoObject(int? id) =>
            this.unitOfWork.GenericRepository<Picture>()
                .Get()
                .Where(p => p.InfoId == id)
                .Select(p => new ImageInsertUpdateViewModel
                {
                    IdPicture = p.Id,
                    InfoId = p.InfoId.Value,
                    fotoName = p.Name,
                    Image = p.Image


                })
                .ToList<ImageInsertUpdateViewModel>();



        public void InsertImage(ImageParameters parameters)
        {
            var config = new ImageResizer.Configuration.Config();

            var inputStream = new MemoryStream(parameters.Image);
            inputStream.Seek(0, SeekOrigin.Begin);
            var outputStream = new MemoryStream();

            var job = new ImageJob(inputStream, outputStream, new Instructions("width=100"));

            config.Build(job);
            outputStream.Seek(0, SeekOrigin.Begin);

            Picture myImage = new Picture
            {
                InfoId = parameters.InfoId,
                Name = parameters.fotoName,
                Image = parameters.Image,
                Thumbnail = outputStream.GetBuffer()
            };

            this.unitOfWork.GenericRepository<Picture>().InsertGraph(myImage);
            this.unitOfWork.SaveChanges();
        }
    }
}
