using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class VillageHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public VillageHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public VillageHandler()
            : this(new UnitOfWork())
        {
        }

    }
}
