﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer.Domain.ViewModels
{
    public class ComplaintAndSuggestionVM
    {
        public int id { get; set; }
        public string userid { get; set; }
        //public User user { get; set; }
        public DateTime date { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}
