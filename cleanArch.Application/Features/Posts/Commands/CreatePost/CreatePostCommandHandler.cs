using AutoMapper;
using cleanArch.Application.Contracts;
using cleanArch.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArch.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Guid>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }

        public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            // CreatePostCommand => Post (must be configured in profiles)
            Post post = _mapper.Map<Post>(request);
            CreateCommandValidator validator = new();
            var result = await validator.ValidateAsync(request);
            if (result.Errors.Any()) throw new Exception("invalid post");
            post = await _postRepository.AddAsync(post);
            return post.Id;
        }
    }
}