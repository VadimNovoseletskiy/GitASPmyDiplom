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
        /// <summary>
        /// Property House 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The property TypeHouse 
        /// </summary>
        ///<value>
        /// Type of House   
        /// </value>
        public string TypeHouse { get; set; }


        /// <summary>
        /// The property PartHouse
        /// </summary>
        /// <value>
        /// Part of House 
        ///  </value>
        public string PartHouse { get; set; }


        /// <summary>
        /// The property RoomsHouse
        /// </summary>
        /// <value>
        /// Number of rooms in the house 
        /// </value>
        public int RoomsHouse { get; set; }


        /// <summary>
        /// The property FloorHouse
        /// </summary>
        /// <value>
        /// Number of floors in the house  
        /// </value>
        public int FloorHouse { get; set; }


        /// <summary>
        /// The property LivingAreaHouse
        /// </summary>
        /// <value>
        /// Living area of house  
        /// </value>
        public float LivingAreaHouse { get; set; }


        /// <summary>
        /// The property KitchenAreaHouse
        /// </summary>
        ///<value>
        /// Living area kitchen in the house  
        /// </value> 
        public float KitchenAreaHouse { get; set; }


        /// <summary>
        /// The property LandAreaHouse
        /// </summary>
        /// <value>
        /// Area of adjacent land 
        /// </value>
        public float LandAreaHouse { get; set; }

    }
}
