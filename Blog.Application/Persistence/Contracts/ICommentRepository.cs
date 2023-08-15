using Blog.Domain;

namespace Blog.Application.Persistence.Contracts;

public interface ICommentRepository : IGenericRepository<Comment>
{
}