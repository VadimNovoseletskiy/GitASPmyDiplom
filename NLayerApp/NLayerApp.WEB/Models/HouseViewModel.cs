using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.DataTransferObject
{
    /// <summary>
    /// Describes an object "House"
    /// </summary>
    public class HouseViewModel
    {
        
        public int Id { get; set; }

        public string TypeHouse { get; set; }

        public string PartHouse { get; set; }

        public int RoomsHouse { get; set; }

        public int FloorHouse { get; set; }

        public float LivingAreaHouse { get; set; }

        public float KitchenAreaHouse { get; set; }

        public float LandAreaHouse { get; set; }

    }
}
