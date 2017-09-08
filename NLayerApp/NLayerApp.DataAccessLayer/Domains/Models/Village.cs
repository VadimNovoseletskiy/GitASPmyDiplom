using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    public class Village
    {
        /// <summary>
        /// The properties Id 
        /// </summary>
        /// <value>
        /// The Id 
        /// </value>
        public int Id { get; set; }


        /// <summary>
        /// The properties VillageName 
        /// </summary>
        /// <value>
        /// Name of the village    
        /// </value>
        public string VillageName { get; set; }

        //Links:

        /// <summary>
        /// The navigation property.
        /// The link to the class "Info"(one to many communication)
        /// </summary>
        public ICollection<Info> Infos { get; set; }
        public Village()
        {
            Infos = new List<Info>();
        }
    }
}
