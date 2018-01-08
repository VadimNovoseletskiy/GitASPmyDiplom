using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class ImageInsertUpdateViewModel
    {
        /*выаод дополнительной информации для подтвержления  ввода картинки выбранному обьтекту  */

       

        //image
        public int IdObject { get; set; }
        public int InfoId { get; set; }
        public string fotoName { get; set; }
        public byte[] Image { get; set; }

    }
}
