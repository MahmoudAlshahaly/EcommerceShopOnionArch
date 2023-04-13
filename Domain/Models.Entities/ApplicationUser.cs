using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SharedLayer.Domain.Models.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public bool IsAdmin { get; set; }
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}