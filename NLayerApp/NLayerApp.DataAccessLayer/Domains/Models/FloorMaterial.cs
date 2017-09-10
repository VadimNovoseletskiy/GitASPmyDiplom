using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Description of the material on the floor 
    /// </summary>
    public class FloorMaterial
    {
        /// <summary>
        /// The property Id 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The property NameFloorMaterils
        /// </summary>
        ///<value>
        /// Describe : Material name
        /// </value>
        public string NameFloorMaterils { get; set; }

        //Links:

        /// <summary>
        /// The Foreign Key.
        /// The link to the class "Material"  (one to many communication)
        /// </summary>
        public int? MaterialId { get; set; }
        public Material Material { get; set; }

    }
}
