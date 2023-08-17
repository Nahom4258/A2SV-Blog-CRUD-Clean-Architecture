using AutoMapper;
using Blog.Application.DTOs;
using Blog.Application.Features.Post.Requests;
using Blog.Application.Features.Post.Requests.Commands;
using Blog.Application.Persistence.Contracts;
using MediatR;

namespace Blog.Application.Features.Post.Handlers.Commands;

public class CreatePostHandler : IRequestHandler<CreatePostRequest, int>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public CreatePostHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreatePostRequest request, CancellationToken cancellationToken)
    {
        var post = _mapper.Map<Domain.Post>(request.PostDto);

        post = await _postRepository.Add(post);

        return post.Id;
    }
}