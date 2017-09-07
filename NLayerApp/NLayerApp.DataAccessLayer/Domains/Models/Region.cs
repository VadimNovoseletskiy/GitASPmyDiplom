using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Describes the areas where the property is located   
    /// </summary>
    /// 
    public class Region
    {
            /// <summary>
            /// The property Id 
            /// </summary>
            public int Id { get; set; }
            /// <summary>
            /// The property RegionName 
            /// </summary>
            ///<value>
            /// The district name  
            /// </value>
            public string RegionName { get; set; }

            //Links:
            /// <summary>
            /// The navigation property.
            /// The link to the class"Info" (one to many communication
            /// </summary> 
            public ICollection<Info> Infos { get; set; }
            public Region()
            {
                Infos = new List<Info>();
            }
        }
    
}
