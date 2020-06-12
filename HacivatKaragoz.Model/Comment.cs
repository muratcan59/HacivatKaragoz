using System;
using System.Collections.Generic;

namespace HacivatKaragoz.Model.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public string CommentPost { get; set; }
        public bool? IsApprove { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public DateTime? AddedDate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
