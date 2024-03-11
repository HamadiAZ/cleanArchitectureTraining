using AutoMapper;
using cleanArch.Application.Features.Posts.Queries.GetPostDetail;
using cleanArch.Application.Features.Posts.Queries.GetPostsList;
using cleanArch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArch.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() { 
            CreateMap<Post, GetPostsListViewModel>().ReverseMap();
            CreateMap<Post, GetPostDetailViewModel>().ReverseMap();
        }
        
    }
}
