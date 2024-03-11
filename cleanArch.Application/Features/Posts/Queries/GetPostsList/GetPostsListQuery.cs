using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArch.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery:IRequest<List<GetPostsListViewModel>>
    {
        // IRequest<Return TYPE>
    }
}
