using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOTR.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentAuthor { get; set; }

        public string CommentText { get; set; }

        public string DateTime { get; set; }

        public virtual ApplicationUser User { set; get; }
    }
}