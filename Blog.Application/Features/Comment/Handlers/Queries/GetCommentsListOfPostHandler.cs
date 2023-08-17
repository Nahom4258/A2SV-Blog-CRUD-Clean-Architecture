using AutoMapper;
using Blog.Application.DTOs;
using Blog.Application.Features.Comment.Requests.Queries;
using Blog.Application.Persistence.Contracts;
using MediatR;

namespace Blog.Application.Features.Comment.Handlers.Queries;

public class GetCommentsListOfPostHandler : IRequestHandler<GetCommentsListOfPostRequest, List<CommentDto>>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;

    public GetCommentsListOfPostHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }
    
    public async Task<List<CommentDto>> Handle(GetCommentsListOfPostRequest request, CancellationToken cancellationToken)
    {
        var comments = await _commentRepository.GetCommentsListOfPost(request.PostId);

        return _mapper.Map<List<CommentDto>>(comments);
    }
}