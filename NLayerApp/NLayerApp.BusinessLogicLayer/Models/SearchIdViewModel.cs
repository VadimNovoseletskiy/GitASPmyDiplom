using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class SearchIdViewModel
    {
        public int Id { get; set; }
        public PropertyType MyType { get; set; }
    }
}
