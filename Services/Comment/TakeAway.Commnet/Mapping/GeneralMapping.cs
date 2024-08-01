using AutoMapper;
using TakeAway.Comment.DAl.Entities;
using TakeAway.Comment.Dtos;

namespace TakeAway.Comment.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<UserComment, ResultUserCommentDto>().ReverseMap();
            CreateMap<UserComment, GetByIdUserCommentDto>().ReverseMap();
            CreateMap<UserComment, CreateUserCommentDto>().ReverseMap();
            CreateMap<UserComment, UpdateUserCommentDto>().ReverseMap();
        }
    }
}
