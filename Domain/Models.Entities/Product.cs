using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.Models.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal saleprice { get; set; }
        public decimal buyprice { get; set; }
        public decimal quantityavailable { get; set; }
        public string imageurl { get; set; }
        [ForeignKey("Category")]
        public int Categoryid { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Brand")]
        public int Brandid { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; } = new HashSet<OrderDetails>();
        public virtual ICollection<ProductImage> ProductImage { get; set; } = new HashSet<ProductImage>();
        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

    }
}
