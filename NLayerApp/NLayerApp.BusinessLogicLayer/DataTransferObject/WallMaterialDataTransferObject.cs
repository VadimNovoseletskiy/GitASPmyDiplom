using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.DataTransferObject
{
    public class WallMaterialDataTransferObject
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
    }
}
