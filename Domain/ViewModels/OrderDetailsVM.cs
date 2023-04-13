using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public class OrderDetailsVM
    {
        public int id { get; set; }
        [ForeignKey("Product")]
        public int Productid { get; set; }
        public ProductVM Product { get; set; }
        public decimal saleprice { get; set; }
        public decimal quantity { get; set; }
        public decimal totalsale { get; set; }
        public decimal totalprofit { get; set; }

        [ForeignKey("Order")]
        public int Orderid { get; set; }
        public OrderVM Order { get; set; }
    }
}
