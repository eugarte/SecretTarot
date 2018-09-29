using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecretTarot.Infrastructure.Data;
using SecretTarot.Module.Core.Extensions;
using SecretTarot.Module.Reviews.ViewModels;
using System.Threading.Tasks;

namespace SecretTarot.Module.Reviews.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IRepository<Models.Reply> _replyRepository;
        private readonly IWorkContext _workContext;

        public ReplyController(IRepository<Models.Reply> replyRepository, IWorkContext workContext)
        {
            _replyRepository = replyRepository;
            _workContext = workContext;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddReply(ReplyForm model)
        {
            if (ModelState.IsValid)
            {
                var user = await _workContext.GetCurrentUser();

                var reply = new Models.Reply
                {
                    ReviewId = model.ReviewId,
                    UserId = user.Id,
                    Comment = model.Comment,
                    ReplierName = model.ReplierName,
                };

                _replyRepository.Add(reply);
                _replyRepository.SaveChanges();

                return PartialView("_ReplyFormSuccess", model);
            }

            return PartialView("_ReplyForm", model);
        }
    }
}