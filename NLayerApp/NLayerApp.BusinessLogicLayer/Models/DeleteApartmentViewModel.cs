using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class DeleteApartmentViewModel
    {
        public int Id { get; set; }

        //Address
        public int Village { get; set; }
        public int Region { get; set; }
        public int Street { get; set; }
        public string NumberAdress { get; set; }

        // information
        public string OperationType { get; set; }
        public string RoomsApartment { get; set; }
        public string TypeRoom { get; set; }
        public int  ApartmentNumber { get; set; }

        //Details Info
        public string InfoDetails { get; set; }
    }
}
