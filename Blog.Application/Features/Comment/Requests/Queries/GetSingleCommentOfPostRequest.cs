using Blog.Application.DTOs;
using MediatR;

namespace Blog.Application.Features.Comment.Requests.Queries;

public class GetSingleCommentOfPostRequest : IRequest<CommentDto>
{
    public int PostId { get; set; }
    public int CommentId { get; set; }
}