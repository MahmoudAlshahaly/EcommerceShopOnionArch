using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.Models.Entities
{
    public class FavoriteProduct
    {
        public int id { get; set; }
        public string userid { get; set; }
      //public User User { get; set; }

        [ForeignKey("Product")]
        public int productid { get; set; }
        public virtual Product Product { get; set; }
      
    }
}
