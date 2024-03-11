using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace cleanArch.Application.Features.Posts.Commands.CreatePost
{
    public class CreateCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Title).NotEmpty().MaximumLength(90).NotNull();
            RuleFor(p => p.Content).NotEmpty().NotNull();
        }
    }
}