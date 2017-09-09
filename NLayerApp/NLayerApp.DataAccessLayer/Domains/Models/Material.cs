using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Description of materials  
    /// </summary>

    public class Material
    {
        public int Id { get; set; }

        /// <summary>
        /// The property NameWallMaterial
        /// </summary>
        ///<value>
        /// Wall material
        /// </value>
        public string NameWallMaterial { get; set; }


        /// <summary>
        /// The property NameFloorMaterial 
        /// </summary>
        /// <value>
        /// Floor material  
        /// </value>
        public string NameFloorMaterial { get; set; }



    }
}
