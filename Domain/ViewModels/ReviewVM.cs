using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public  class ReviewVM
    {
        public int id { get; set; }
        public string userid { get; set; }
        //public user user { get; set; }
        public int productid { get; set; }
        public virtual ProductVM Product { get; set; }
        public string comment { get; set; }
        public int rate { get; set; }
        public DateTime date { get; set; }
    }
}
