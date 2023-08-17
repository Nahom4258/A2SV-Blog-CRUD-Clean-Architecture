using Blog.Application.DTOs;
using Blog.Domain;

namespace Blog.Application.Profile;

public class MappingProfile : AutoMapper.Profile
{
    public MappingProfile()
    {
        CreateMap<Post, PostDto>().ReverseMap();
        CreateMap<Comment, CommentDto>().ReverseMap();
    }
}