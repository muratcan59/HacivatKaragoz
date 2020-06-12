using System;
using System.Collections.Generic;

namespace HacivatKaragoz.Model.Models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Media { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
