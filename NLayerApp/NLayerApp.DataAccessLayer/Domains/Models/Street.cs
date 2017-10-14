using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Describes the streets
    /// </summary>
     public class Street
    {
        /// <summary>
        /// The property "Id"
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The property Street
        /// </summary>
        public string StreetName { get; set; }

        //Links:


        /// <summary>
        /// The navigation property.
        /// The link to the class"Info" (one to many communication
        /// </summary> 
        public ICollection<Info> Infos { get; set; }

        public Street()
        {
            Infos=new List<Info>();
        }
    }
}
