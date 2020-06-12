using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace HacivatKaragoz.Model.Models
{
    public partial class Role:IdentityRole<int>
    {
        public Role()
        {
            Customer = new HashSet<Customer>();
            User = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
