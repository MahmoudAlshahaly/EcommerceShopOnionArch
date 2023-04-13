using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.Models.Entities
{
    public class ProductImage
    {
        public int id { get; set; }

        [ForeignKey("Product")]
        public int Productid { get; set; }
        public virtual Product Product { get; set; }
        public string imageurl { get; set; }
    }
}
