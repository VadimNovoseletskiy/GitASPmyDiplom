using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class ImageViewModel
    {

        /*выаод дополнительной информации для подтвержления  ввода картинки выбранному обьтекту  */

        //land address
        public int Village { get; set; }
        public int Region { get; set; }
        public int Street { get; set; }
        public string NumberAdress { get; set; }
        //????add kadastr
        

        //special information
        public double LandArea { get; set; }

        //image
        public string fotoName { get; set; }
        public byte[] Image { get; set; }

    }
}
