using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.HandlerOutPut
{
    public class MaterialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public MaterialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork=new UnitOfWork();
        }

        public MaterialHandler() : this(new UnitOfWork())
        {
            
        }
    }
}
