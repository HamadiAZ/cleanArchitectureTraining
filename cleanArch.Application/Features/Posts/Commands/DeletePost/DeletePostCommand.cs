using MediatR;
using System;

namespace cleanArch.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest<Unit>
    {
        public Guid PostId { get; set; }
    }
}