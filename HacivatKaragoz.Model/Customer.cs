using System;
using System.Collections.Generic;

namespace HacivatKaragoz.Model.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Comment = new HashSet<Comment>();
            Contact = new HashSet<Contact>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
