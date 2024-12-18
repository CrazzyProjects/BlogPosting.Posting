using BlogPosting.Posting.Domain.Entities;
using BlogPosting.Posting.Domain.Interfaces;
using BlogPosting.Posting.Infrastructure.Context;
using BlogPosting.Posting.Infrastructure.Models;

namespace BlogPosting.Posting.Infrastructure.Repositories
{
    public class SqlPostingRepository : IPostingRepository
    {
        private readonly BlogPostingDBContext _context;
        private readonly IPostingMapper _mapper;
        public SqlPostingRepository(BlogPostingDBContext context, IPostingMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> SavePostAsync(PublishPost publishPost)
        {
            // TODO: Test 2
            PublishPostModel publishPostModel = _mapper.MapToPublishPostModel(publishPost);
            await _context.Posting.AddAsync(publishPostModel);
            int result = await _context.SaveChangesAsync();

            publishPost.PostingId = publishPostModel.PostingId;

            return result > 0;
        }
    }
}
