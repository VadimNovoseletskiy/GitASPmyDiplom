using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class ApartmerntInputParameters
    {
        public PropertyType Type = PropertyType.Apartment;
        //Address
        public string Village { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string NumberAdress { get; set; }
        public TypeOfOperation OperationType { get; set; }

        //Details Info  

    }
}
