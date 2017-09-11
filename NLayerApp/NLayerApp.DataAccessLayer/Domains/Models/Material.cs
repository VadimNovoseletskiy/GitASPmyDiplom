using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        /// <summary>
        /// The  Foreign Key(one to one communication). Link to the Parent  class "Apartment" "House"
        /// </summary>
        [Key]
        public int Id { get; set; }


        //Links:

        /// <summary>
        /// The navigation property.
        /// The link to the class "WallMaterial"(one to many communication)
        /// </summary>
        public ICollection<WallMaterial> WallMaterials { get; set; }

        /// <summary>
        /// The navigation property.
        /// The link to the class "FloorMaterial"(one to many communication)
        /// </summary>
        public ICollection<FloorMaterial> FloorMaterials { get; set; }

        public Material()
        {
            WallMaterials = new List<WallMaterial>();
            FloorMaterials=new List<FloorMaterial>();
        }

        /// <summary>
        /// The link to the parent class Apartment(one to one communication)
        /// </summary>
        public Apartment Apartment { get; set; }

        /// <summary>
        /// The link to the parent class House(one to one communication)
        /// </summary>
        public House House { get; set; }

        /// <summary>
        /// The link to the parent class Commercial(one to one communication)
        /// </summary>
        public Commercial Commercial { get; set; }

    }
}
