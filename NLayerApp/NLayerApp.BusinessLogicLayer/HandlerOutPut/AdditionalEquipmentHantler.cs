using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.HandlerOutPut
{
    public class AdditionalEquipmentHantler
    {
        private readonly IUnitOfWork unitOfWork;

        public AdditionalEquipmentHantler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public AdditionalEquipmentHantler() : this(new UnitOfWork())
        {

        }
    }
}
