using AutoMapper;
using Blog.Application.Features.Comment.Requests.Commands;
using Blog.Application.Persistence.Contracts;
using MediatR;

namespace Blog.Application.Features.Comment.Handlers.Commands;

public class CreateCommentHandler : IRequestHandler<CreateCommentRequest, int>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;

    public CreateCommentHandler(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }
    
    public async Task<int> Handle(CreateCommentRequest request, CancellationToken cancellationToken)
    {
        var comment = _mapper.Map<Domain.Comment>(request.CommentDto);

        comment = await _commentRepository.Add(comment);

        return comment.Id;
    }
}