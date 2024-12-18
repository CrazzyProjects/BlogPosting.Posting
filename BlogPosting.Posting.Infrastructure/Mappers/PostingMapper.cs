using BlogPosting.Posting.Domain.Entities;
using BlogPosting.Posting.Domain.Interfaces;
using BlogPosting.Posting.Infrastructure.Models;
using Mapster;

namespace BlogPosting.Posting.Infrastructure.Mappers
{
    public class PostingMapper : IPostingMapper
    {
        public PostingMapper()
        {
            _ = TypeAdapterConfig<PublishPost, PublishPostModel>.NewConfig()
                .Map(dest => dest.PostingContent, src => src.Content);
        }
        public PublishPostModel MapToPublishPostModel(PublishPost publishPost)
        {
            return publishPost.Adapt<PublishPostModel>();
        }
    }
}
