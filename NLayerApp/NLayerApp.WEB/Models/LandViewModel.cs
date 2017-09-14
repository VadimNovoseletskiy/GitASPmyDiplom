using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.DataTransferObject
{
    /// <summary>
    /// Describes an object"Land"
    /// </summary>
    public class LandDataTransferLayer
    {
        /// <summary>
        /// The property Id 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The property SpesialLand
        /// </summary>
        ///<value>
        /// Describe special Land
        /// </value>
        public string SpecialLand { get; set; }


        /// <summary>
        /// The property LandArea
        /// </summary>
        /// <value>
        /// Land plot area
        /// </value>
        public float LandArea { get; set; }
    }
}
