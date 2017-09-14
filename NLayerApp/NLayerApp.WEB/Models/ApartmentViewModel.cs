using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    /// <summary>
    /// Describes an object "Apartment"
    /// </summary>
    public class ApartmentViewModel
    {
        
        public int Id { get; set; }

        public int TotalFloorApartment { get; set; }

        public int FloorApartment { get; set; }

        public float LivingAreaApartment { get; set; }

        public float KitchenAreaApartment { get; set; }

        public int RoomsApartment { get; set; }

        public string BathRoomApartment { get; set; }

        public int BalconyApartment { get; set; }

        public string ReadinessApartment { get; set; }
    }
}
