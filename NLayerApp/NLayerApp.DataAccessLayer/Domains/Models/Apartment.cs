using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Describes an object "Apartment"
    /// </summary>
    public class Apartment
    {
        public int Id { get; set; }
        /// <summary>
        /// Property Number of floors in the house
        /// </summary>
        /// <value>
        /// Describes number of floors in the house
        /// </value>
        public int TotalFloorApartment { get; set; }


        /// <summary>
        /// Property FloorApartment
        /// </summary>
        /// <value>
        /// Describes floor, where is the  apartment  
        /// </value>
        public int FloorApartment { get; set; }


        /// <summary>
        /// Property LivingAreaApartment
        /// </summary>
        /// <value>
        /// Describes living space   
        /// </value>
        public float LivingAreaApartment { get; set; }


        /// <summary>
        /// Property KitchenAreaApartment
        /// </summary>
        /// <value>
        /// Describes kitchen area
        /// </value>
        public float KitchenAreaApartment { get; set; }


        /// <summary>
        /// Property RoomsApartment
        /// </summary>
        /// <value>
        /// Describes the number of rooms in the apartment 
        /// </value>
        public int RoomsApartment { get; set; }


        /// <summary>
        /// Property BathRoomApartment
        /// </summary>
        /// <value>
        /// Describes the bathroom
        /// </value>
        public string BathRoomApartment { get; set; }


        /// <summary>
        /// Property BalconyApartment
        /// </summary>
        /// <value>
        ///The presence of a balcony  
        /// </value>
        public int BalconyApartment { get; set; }


        /// <summary>
        /// Property ReadinessApartment
        /// </summary>
        /// <value>
        /// Readiness for setting 
        ///  </value>
        public string ReadinessApartment { get; set; }


    }
}
