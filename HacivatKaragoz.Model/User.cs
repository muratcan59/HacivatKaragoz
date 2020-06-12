using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace HacivatKaragoz.Model.Models
{
    public partial class User:IdentityUser<int>
    {
        public User()
        {
            Comment = new HashSet<Comment>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public Guid? UserGuid { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDelete { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
