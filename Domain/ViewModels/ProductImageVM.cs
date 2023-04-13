using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public class ProductImageVM
    {
        public int id { get; set; }
        public int Productid { get; set; }
        public ProductVM Product { get; set; }
        public string imageurl { get; set; }
    }
}
