using System;
using System.Collections.Generic;

namespace HacivatKaragoz.Model.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public Guid? ContactGuid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Phone { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
