using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class ImageParameters
    {
        public int Id { get; set; }
        public string fotoName { get; set; }
        public byte[] Image { get; set; }

        public int InfoId { get; set; }
    }
}
