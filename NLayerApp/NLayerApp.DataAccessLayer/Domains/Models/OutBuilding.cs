using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Describes outbuilding  
    /// </summary>
    public class OutBuilding
    {
        public int Id { get; set; }


        /// <summary>
        /// The property BahtHouseOutBuilding 
        /// </summary>
        ///<value>
        /// The Bathhouse 
        ///</value>
        public bool BahtHouseOutBuilding { get; set; }


        /// <summary>
        /// The property SwimmingOutBuildings
        /// </summary>
        /// <value>
        /// The swimming-pool 
        /// </value>
        public bool SwimmingOutBuildings { get; set; }


        /// <summary>
        /// The property GarageOutBuildings 
        /// </summary>
        /// <value>
        /// The Garage
        /// </value>
        public bool GarageOutBuildings { get; set; }


        /// <summary>
        /// The property WellOutBuildings 
        /// </summary>
        /// <value>
        /// The  Well
        /// </value>
        public bool WellOutBuildings { get; set; }


        /// <summary>
        /// The property SummerKitchenOutBuildings
        /// </summary>
        /// <value>
        /// Summer cuisine   
        /// </value>
        public bool SummerKitchenOutBuildings { get; set; }


        /// <summary>
        /// The property WorkShopOutBuildings
        /// </summary>
        /// <value>
        /// The Workshop
        /// </value>
        public bool WorkShopOutBuildings { get; set; }


        /// <summary>
        /// The property BarnOutBuildings 
        /// </summary>
        /// <value>
        /// The Barn 
        /// </value>
        public bool BarnOutBuildings { get; set; }


        /// <summary>
        /// The property Well1OutBuildings
        /// </summary>
        /// <value>
        /// The Well_1
        /// </value>
        public bool Well1OutBuildings { get; set; }


        /// <summary>
        /// The property GreenHouseOutBuildings
        /// </summary>
        /// <value>
        /// The Greenhouse 
        /// </value>
        public bool GreenHouseOutBuildings { get; set; }
    }
}
