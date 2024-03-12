using AutoMapper;
using cleanArch.Application.Contracts;
using cleanArch.Domain;
using MediatR;
using System;

namespace cleanArch.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, Unit>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public UpdatePostCommandHandler(IMapper mapper, IAsyncRepository<Post> postRep)
        {
            _mapper = mapper;
            _postRepository = postRep;
        }

        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            Post post = _mapper.Map<Post>(request);
            await _postRepository.UpdateAsync(post);
            return Unit.Value;
        }
    }
}