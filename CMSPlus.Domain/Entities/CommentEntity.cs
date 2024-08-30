using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Entities
{
    public class CommentEntity : BaseEntity
    {
        [Required]
        [MaxLength(400)]
        public string Content { get; set; }
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        public int TopicId { get; set; }
        public TopicEntity Topic { get; set; }
    }
}
