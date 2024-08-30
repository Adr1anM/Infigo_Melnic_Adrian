using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Models.CommentModels
{
    public class CommentModel
    {
        public CommentModel()
        {
            UpdatedOnUtc = CreatedOnUtc = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
    }
}
