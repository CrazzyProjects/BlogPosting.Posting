using BlogPosting.Posting.Application.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPosting.Posting.Application.Commands
{
    public class PublishPostCommandHandler : IRequestHandler<PublishPostCommand, PostingViewModel>
    {
        public Task<PostingViewModel> Handle(PublishPostCommand request, CancellationToken cancellationToken)
        {
            
        }
    }
}
