using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public class CategoryVM
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageurl { get; set; }
        public virtual ICollection<ProductVM> Products { get; set; } = new HashSet<ProductVM>();
        public IFormFile file { get; set; }
    }
}



