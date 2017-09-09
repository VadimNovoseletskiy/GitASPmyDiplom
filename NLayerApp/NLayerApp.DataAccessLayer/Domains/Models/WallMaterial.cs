using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Description of material for walls
    /// </summary>
    public class WallMaterial
    {
        /// <summary>
        /// The property Id 
        /// </summary>
        /// <value>
        /// The Id 
        /// </value>
        public int Id { get; set; }


        /// <summary>
        /// The property NameWallMaterils 
        /// </summary>
        /// <value>
        /// The name of the material for the walls 
        /// </value>
        public string NameWallMaterils { get; set; }

        //Links:

        /// <summary>
        /// The Foreign Key.
        /// The link to the class "Material"  (one to many communication)
        /// </summary>
        public int? MaterialId { get; set; }
        public Material Material { get; set; }
    }
}
