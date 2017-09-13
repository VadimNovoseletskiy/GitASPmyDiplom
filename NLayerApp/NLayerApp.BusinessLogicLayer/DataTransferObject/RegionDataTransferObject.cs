using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.DataTransferObject
{
    /// <summary>
    /// Describes the areas where the property is located   
    /// </summary>
    /// 
    class RegionDataTransferObject
    {
        /// <summary>
        /// The property Id 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The property RegionName 
        /// </summary>
        ///<value>
        /// The district name  
        /// </value>
        public string RegionName { get; set; }
    }
}
