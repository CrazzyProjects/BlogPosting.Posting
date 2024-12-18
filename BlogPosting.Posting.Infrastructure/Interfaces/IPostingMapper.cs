using BlogPosting.Posting.Domain.Entities;
using BlogPosting.Posting.Infrastructure.Models;

namespace BlogPosting.Posting.Domain.Interfaces
{
    public interface IPostingMapper
    {
        PublishPostModel MapToPublishPostModel(PublishPost publishPost);
    }
}
