﻿using System;
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
    public class DeleteCommercialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteCommercialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DeleteCommercialHandler() : this(new UnitOfWork())
        {

        }

        public DeleteCommercialViewModel DeleteFindCommercial(int? id) =>
            this.unitOfWork.GenericRepository<Commercial>()
            .Get()
            .Where(x => x.Id == id)
            .Select(
                        x => new DeleteCommercialViewModel
                        {
                            Id = x.Id,
                            Region = x.Info.RegionId.Value,
                            Village = x.Info.VillageId.Value,
                            Street = x.Info.StreetId.Value,
                            NumberAdress = x.Info.AddressNumber,
                            OperationType = x.Info.OperationType,
                            TypeCommercial = x.TypeCommercial,
                            InfoDetails = x.Info.DetailsInfo,
                        }
                    )
            .FirstOrDefault();

        public void DeleteCommercial(int id)
        {
            this.unitOfWork.GenericRepository<Commercial>().Delete(id);
            this.unitOfWork.GenericRepository<Info>().Delete(id);
            this.unitOfWork.GenericRepository<Communication>().Delete(id);
            this.unitOfWork.GenericRepository<AdditionalEquipment>().Delete(id);
            this.unitOfWork.SaveChanges();
        }
    }
}
