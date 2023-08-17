using Blog.Application.DTOs.Common;

namespace Blog.Application.DTOs;

public class PostDto : BaseDto
{
    public string? Title { get; set; }
    public string? Content { get; set; }
}