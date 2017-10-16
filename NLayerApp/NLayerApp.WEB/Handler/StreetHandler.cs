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
    public class StreetHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public StreetHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public StreetHandler() : this(new UnitOfWork())
        {

        }

        public List<DropDownViewModel> GetStreet()
        {
            List<DropDownViewModel> result = this.unitOfWork.GenericRepository<Street>()
                .Get()
                .Select(
                    p => new DropDownViewModel
                    {
                        Id = p.Id,
                        Value = p.StreetName}
                )
                .ToList<DropDownViewModel>();
            return result;
        }

    }
}