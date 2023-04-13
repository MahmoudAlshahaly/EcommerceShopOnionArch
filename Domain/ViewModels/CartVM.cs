using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public class CartVM
    {
        public int id { get; set; }
        public string userid { get; set; }
        //public User User { get; set; }
        public int Productid { get; set; }
        public ProductVM Product { get; set; }
        public decimal quantity { get; set; }
    }
}
