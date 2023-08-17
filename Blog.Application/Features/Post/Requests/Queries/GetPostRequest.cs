using Blog.Application.DTOs;
using MediatR;

namespace Blog.Application.Features.Post.Requests;

public class GetPostRequest : IRequest<PostDto>
{
    public int Id { get; set; }
}