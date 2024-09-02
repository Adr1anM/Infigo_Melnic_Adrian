using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModels;
using CMSPlus.Domain.Models.TopicModels;
using CMSPlus.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CMSPlus.Presentation.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(TopicDetailsModel topic)
        {
            var entity = topic.NewComment;
            var commentEntity = _mapper.Map<CommentCreateModel, CommentEntity>(entity);
            await _commentService.Create(commentEntity);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Topic");
        }
    }
}
