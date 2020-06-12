using System;
using System.Collections.Generic;

namespace HacivatKaragoz.Model.Models
{
    public partial class Product
    {
        public Product()
        {
            Comment = new HashSet<Comment>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int? Stock { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public DateTime? AddedDate { get; set; }
        public string Title { get; set; }
        public string ProductType { get; set; }
        public string Media { get; set; }
        public string Url { get; set; }
        public int? CategoryId { get; set; }
        public double? ProductWeight { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
