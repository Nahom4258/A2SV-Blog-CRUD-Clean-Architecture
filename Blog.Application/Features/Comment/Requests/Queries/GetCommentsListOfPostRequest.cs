using Blog.Application.DTOs;
using MediatR;

namespace Blog.Application.Features.Comment.Requests.Queries;

public class GetCommentsListOfPostRequest : IRequest<List<CommentDto>>
{
    public int PostId { get; set; }
}