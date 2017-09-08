using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    public class Info
    {
        /// <summary>
        /// The property Id 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The property NameInfo 
        /// </summary>
        /// <value>
        /// Short title 
        /// </value>
        public string NameInfo { get; set; }


        /// <summary>
        /// The property DetailsInfo
        /// </summary>
        /// <value>
        /// Detailed description of the property  
        /// </value>
        public string DetailsInfo { get; set; }


        /// <summary>
        /// The property Type 
        /// </summary>
        /// <value>
        /// Object type 
        /// </value>
        public int Type { get; set; }


        /// <summary>
        /// The property TotalAreaInfo 
        /// </summary>
        /// <value>
        /// Common object
        /// </value>
        public float TotalAreaInfo { get; set; }


        /// <summary>
        /// The property GrnPrice
        /// </summary>
        /// <value>
        /// The price of the object in UAN
        /// </value>
        public int GrnPrice { get; set; }


        /// <summary>
        /// The property DollarPrice
        /// </summary>
        /// <value>
        /// The price of the object in dollars 
        /// </value>
        public int DollarPrice { get; set; }

        
        //Links:

        /// <summary>
        /// Foreign Key
        /// The link to the class "Village"(one to many communication) 
        /// </summary>
        public int? VillageId { get; set; }
        public Village Village { get; set; }



    }
}
