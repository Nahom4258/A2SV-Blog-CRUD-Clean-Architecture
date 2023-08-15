namespace Blog.Domain.Common;

public abstract class BaseDomainEntity
{
    public int Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}