using AutoMapper;
using cleanArch.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArch.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<GetPostsListViewModel>>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostsListQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<List<GetPostsListViewModel>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAllPostsAsync(true);
            return _mapper.Map<List<GetPostsListViewModel>>(posts);
        }
    }
}
