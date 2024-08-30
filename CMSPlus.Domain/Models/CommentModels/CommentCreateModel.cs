using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Models.CommentModels
{
    public class CommentCreateModel
    {
        public string FullName { get; set; }
        public string Content { get; set; }
        public int TopicId { get; set; }
    }
}
