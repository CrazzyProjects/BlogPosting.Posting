using BlogPosting.Posting.Application.ViewModel;
using MediatR;

namespace BlogPosting.Posting.Application.Commands
{
    public class PublishPostCommand : IRequest<PostingViewModel>
    {
        public required string UserCode { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateDate { get; set; }
    }
}
