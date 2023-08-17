using Blog.Application.DTOs;
using MediatR;

namespace Blog.Application.Features.Post.Requests.Commands;

public class CreatePostRequest : IRequest<int>
{
    public PostDto PostDto { get; set; }
}