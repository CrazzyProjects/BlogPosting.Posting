using BlogPosting.Posting.Domain.Entities;

namespace BlogPosting.Posting.Domain.Interfaces
{
    public interface IPostingRepository
    {
        Task<bool> SavePostAsync(PublishPost publishPost);
    }
}
