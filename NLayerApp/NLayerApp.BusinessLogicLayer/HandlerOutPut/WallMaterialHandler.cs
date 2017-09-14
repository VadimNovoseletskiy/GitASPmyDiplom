using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.HandlerOutPut
{
    public class WallMaterialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public WallMaterialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public WallMaterialHandler() : this(new UnitOfWork())
        {
            
        }

    }
}
