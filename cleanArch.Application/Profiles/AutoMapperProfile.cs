using AutoMapper;
using cleanArch.Application.Features.Posts.Commands.CreatePost;
using cleanArch.Application.Features.Posts.Commands.DeletePost;
using cleanArch.Application.Features.Posts.Commands.UpdatePost;
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
        public AutoMapperProfile()
        {
            CreateMap<Post, GetPostsListViewModel>().ReverseMap();
            CreateMap<Post, GetPostDetailViewModel>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();
        }
    }
}