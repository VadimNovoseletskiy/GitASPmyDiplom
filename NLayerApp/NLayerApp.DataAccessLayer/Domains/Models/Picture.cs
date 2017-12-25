using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    public class Picture
    {

        public int Id { get; set; }
        public string Name { get; set;}
        public byte[] Image { get; set; }

       

        //Links

        /// <summary>
        /// The foreign key
        /// The link to the class "Info"(one to many communication)
        /// </summary>
        public int? InfoId { get; set; }
        public Info Info { get; set; }
    }
}
