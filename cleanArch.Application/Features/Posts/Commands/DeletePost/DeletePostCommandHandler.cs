using AutoMapper;
using cleanArch.Application.Contracts;
using cleanArch.Domain;
using MediatR;
using System;

namespace cleanArch.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, Unit>
    {
        private readonly IAsyncRepository<Post> _postRepository;

        public DeletePostCommandHandler(IAsyncRepository<Post> postRep)
        {
            _postRepository = postRep;
        }

        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            Post post = await _postRepository.GetByIdAsync(request.PostId);
            await _postRepository.DeleteAsync(post);
            return Unit.Value;
        }
    }
}