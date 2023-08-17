using AutoMapper;
using Blog.Application.DTOs;
using Blog.Application.Features.Comment.Requests.Queries;
using Blog.Application.Persistence.Contracts;
using MediatR;

namespace Blog.Application.Features.Comment.Handlers.Queries;

public class GetSingleCommentOfPostHandler : IRequestHandler<GetSingleCommentOfPostRequest, CommentDto>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;

    public GetSingleCommentOfPostHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }
    
    public async Task<CommentDto> Handle(GetSingleCommentOfPostRequest request, CancellationToken cancellationToken)
    {
        var comment = await _commentRepository.GetSingleCommentOfPost(request.PostId, request.CommentId);

        return _mapper.Map<CommentDto>(comment);
    }
}