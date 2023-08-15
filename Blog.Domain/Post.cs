using Blog.Domain.Common;

namespace Blog.Domain;

public class Post : BaseDomainEntity
{

    public string? Title { get; set; }

    public string? Content { get; set; }
    
}