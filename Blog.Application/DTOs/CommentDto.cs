using Blog.Application.DTOs.Common;

namespace Blog.Application.DTOs;

public class CommentDto : BaseDto
{
    public string? Text { get; set; }
    public int PostId { get; set; }
    public PostDto? Post { get; set; }
}