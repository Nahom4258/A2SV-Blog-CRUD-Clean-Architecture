using Blog.Domain.Common;

namespace Blog.Domain;

public partial class Comment : BaseDomainEntity
{
    public string? Text { get; set; }
    public int PostId { get; set; }
    public virtual Post? Post { get; set; }
}