using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class AdminApartmentViewModel
    {
        public int Id { get; set; }
        public string OperationType { get; set; }
        public string Village { get; set; }
        public string Street { get; set; }
        public string AddressNumber { get; set; }
        public int  ApartmentNumber { get; set; }
    }
}
