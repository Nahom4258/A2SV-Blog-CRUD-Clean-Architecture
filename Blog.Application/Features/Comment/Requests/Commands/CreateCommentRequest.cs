using Blog.Application.DTOs;
using MediatR;

namespace Blog.Application.Features.Comment.Requests.Commands;

public class CreateCommentRequest : IRequest<int>
{
    public CommentDto CommentDto { get; set; }
}