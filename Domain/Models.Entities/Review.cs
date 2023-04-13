using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.Models.Entities
{
    public class Review
    {
        public int id { get; set; }
        public string userid { get; set; }
      //public user user { get; set; }

        [ForeignKey("Product")]
        public int productid { get; set; }
        public virtual Product Product { get; set; }
        public string comment { get; set; }
        public int rate { get; set; }
        public DateTime date { get; set; }
    }
}
