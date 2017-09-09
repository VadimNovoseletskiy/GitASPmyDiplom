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

        /// <summary>
        /// The navigation property.
        /// The link to the class "WallMaterial"(one to many communication)
        /// </summary>
        public ICollection<WallMaterial> WallMaterials { get; set; }

        public Material()
        {
            WallMaterials = new List<WallMaterial>();
        }


    }
}
