using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    public class Pictupe
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public byte[] Image { get; set; }
    }
}
