using BlogPosting.Posting.Application.ViewModel;
using BlogPosting.Posting.Domain.Entities;
using BlogPosting.Posting.Domain.Interfaces;
using Mapster;
using MediatR;

namespace BlogPosting.Posting.Application.Commands
{
    public class PublishPostCommandHandler : IRequestHandler<PublishPostCommand, PostingViewModel>
    {
        private readonly IPostingRepository _postingRepository;
        public PublishPostCommandHandler(IPostingRepository postingRepository)
        {
            _postingRepository = postingRepository;
        }
        public async Task<PostingViewModel> Handle(PublishPostCommand request, CancellationToken cancellationToken)
        {
            bool result = await _postingRepository.SavePostAsync(request.Adapt<PublishPost>());
            if (!result)
            {
                throw new Exception("Error saving post");
            }

            return request.Adapt<PostingViewModel>();
        }
    }
}
