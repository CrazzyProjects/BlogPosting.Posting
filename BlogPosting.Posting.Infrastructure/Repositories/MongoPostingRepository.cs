using BlogPosting.Posting.Domain.Entities;
using BlogPosting.Posting.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPosting.Posting.Infrastructure.Repositories
{
    public class MongoPostingRepository : IPostingRepository
    {
        public Task<bool> SavePostAsync(PublishPost publishPost)
        {
            throw new NotImplementedException();
        }
    }
}
