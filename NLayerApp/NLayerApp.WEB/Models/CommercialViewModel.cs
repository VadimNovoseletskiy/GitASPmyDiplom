using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    /// <summary>
    /// Describe an object"Commercial property"  
    /// </summary>
    public class CommercialViewModel
    {
        /// <summary>
        /// Property Id 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Property TypeCommersial
        /// </summary>
        /// <value>
        /// Commercial type 
        /// </value>
        public string TypeCommercial { get; set; }


        /// <summary>
        /// Property StateCommersial
        /// </summary>
        /// <value>
        /// State  
        /// </value>
        public string StateCommercial { get; set; }


        /// <summary>
        /// Property FloorCommersial
        /// </summary>
        /// <value>
        /// Floor where is the commercial real estate
        /// </value>
        public int FloorCommercial { get; set; }


        /// <summary>
        /// Property TotalFloorCommersial
        /// </summary>
        /// <value>
        /// Number of floors
        /// </value>
        public int TotalFloorCommercial { get; set; }


        /// <summary>
        /// Property EffectiveAreaCommmersial
        /// </summary>
        /// <value>
        /// Effective area  
        /// </value>
        public float EffectiveAreaCommercial { get; set; }


        /// <summary>
        /// Property LandAreaCommersial
        /// </summary>
        /// <value>
        /// Area of adjacent land 
        ///  </value>
        public float LandAreaCommercial { get; set; }
    }
}
