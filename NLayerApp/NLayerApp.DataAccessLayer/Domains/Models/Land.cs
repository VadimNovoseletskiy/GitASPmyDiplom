using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Describes an object"Land"
    /// </summary>
    public class Land
    {
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
