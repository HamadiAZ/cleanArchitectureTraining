using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using cleanArch.Application.Contracts;
using MediatR;
namespace cleanArch.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery, GetPostDetailViewModel>
    {

        private readonly IMapper _mapper;
        private readonly IPostRepository _repository;

        public GetPostDetailQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _repository = postRepository;
            _mapper = mapper;
        }


        public async Task<GetPostDetailViewModel> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
        {
            var post = await _repository.GetPostByIdAsync(request.PostId, true);
            return _mapper.Map<GetPostDetailViewModel>(post);
        }
    }
}
