using BlogPosting.Posting.Application.Commands;
using BlogPosting.Posting.Application.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogPosting.Posting.Api.Controllers
{
    // http://localhost:5000/api/Posting
    [Route("api/[controller]")]
    [ApiController]
    public class PostingController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PostingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // http://localhost:5000/api/Posting
        [HttpPost]
        public async Task<IActionResult> PublishPostAsync([FromBody] PublishPostCommand publishCommand)
        {
            PostingViewModel resullt = await _mediator.Send(publishCommand);
            return StatusCode(HttpStatusCode.Created.GetHashCode(), resullt);
        }
    }
}
