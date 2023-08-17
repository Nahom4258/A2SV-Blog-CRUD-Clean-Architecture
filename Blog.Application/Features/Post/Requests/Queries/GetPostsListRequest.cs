using Blog.Application.DTOs;
using MediatR;

namespace Blog.Application.Features.Post.Requests;

public class GetPostsListRequest : IRequest<List<PostDto>>
{
}