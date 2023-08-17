using AutoMapper;
using Blog.Application.DTOs;
using Blog.Application.Features.Post.Requests;
using Blog.Application.Persistence.Contracts;
using MediatR;

namespace Blog.Application.Features.Post.Handlers.Queries;

public class GetPostsListHandler : IRequestHandler<GetPostsListRequest, List<PostDto>>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public GetPostsListHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }
    
    public async Task<List<PostDto>> Handle(GetPostsListRequest request, CancellationToken cancellationToken)
    {
        var posts = await _postRepository.GetAll();

        return _mapper.Map<List<PostDto>>(posts);
    }
}