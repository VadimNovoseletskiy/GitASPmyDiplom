using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.DataTransferObject
{
    /// <summary>
    /// The Village 
    /// </summary>
    public class VillageDataTransferObject
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
    }
}
