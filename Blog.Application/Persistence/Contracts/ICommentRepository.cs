using Blog.Domain;

namespace Blog.Application.Persistence.Contracts;

public interface ICommentRepository : IGenericRepository<Comment>
{
    Task<IReadOnlyList<Comment>> GetCommentsListOfPost(int postId);
    Task<Comment> GetSingleCommentOfPost(int postId, int commentId);
}