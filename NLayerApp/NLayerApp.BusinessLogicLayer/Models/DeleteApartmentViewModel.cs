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
        public TypeOfOperation OperationType { get; set; }
        public SpecialRoomsApartment RoomsApartment { get; set; }
        public SpecialTypeRoom TypeRoom { get; set; }

        //Details Info
        public string InfoDetails { get; set; }
    }
}
