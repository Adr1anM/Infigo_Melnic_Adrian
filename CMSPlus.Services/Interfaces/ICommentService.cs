using CMSPlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Services.Interfaces
{
    public interface ICommentService
    {
        public Task Create(CommentEntity entity); 
    }
}
