using AutoMapper;
using Blog.Application.DTOs;
using Blog.Application.Features.Post.Requests;
using Blog.Application.Persistence.Contracts;
using MediatR;

namespace Blog.Application.Features.Post.Handlers.Queries;

public class GetPostHandler : IRequestHandler<GetPostRequest, PostDto>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public GetPostHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }
    
    public async Task<PostDto> Handle(GetPostRequest request, CancellationToken cancellationToken)
    {
        var post = await _postRepository.Get(request.Id);

        return _mapper.Map<PostDto>(post);
    }
}