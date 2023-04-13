using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public class OrderVM
    {
        public int id { get; set; }
        public string Userid { get; set; }
        //public User User { get; set; }
        public decimal total { get; set; }
        public decimal taxvalue { get; set; }
        public decimal totalaftertax { get; set; }
        public DateTime date { get; set; }
        public bool isonlinepaid { get; set; }
        public virtual ICollection<OrderDetailsVM> OrderDetails { get; set; } = new HashSet<OrderDetailsVM>();
    }
}
