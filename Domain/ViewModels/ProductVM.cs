using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public class ProductVM
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal saleprice { get; set; }
        public decimal buyprice { get; set; }
        public decimal quantityavailable { get; set; }
        public string imageurl { get; set; }
        public int Categoryid { get; set; }
        public virtual CategoryVM Category { get; set; }
        public int Brandid { get; set; }
        public virtual BrandVM Brand { get; set; }
        public virtual ICollection<OrderDetailsVM> OrderDetails { get; set; } = new HashSet<OrderDetailsVM>();
        public virtual ICollection<ProductImageVM> ProductImage { get; set; } = new HashSet<ProductImageVM>();
        public virtual ICollection<ReviewVM> Reviews { get; set; } = new HashSet<ReviewVM>();
        public bool isFavorite { get; set; } = false;
        public IFormFileCollection files { get; set; }
        public List<BrandVM> Brands { get; set; }
        public List<CategoryVM> Categories { get; set; }
    }
}
