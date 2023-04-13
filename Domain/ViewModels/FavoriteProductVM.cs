using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public class FavoriteProductVM
    {
        public int id { get; set; }
        public string userid { get; set; }
      //public User User { get; set; }
        public int productid { get; set; }
        public virtual ProductVM Product { get; set; }
      
    }
}
