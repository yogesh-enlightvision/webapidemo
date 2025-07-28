using AutoMapper;
using MyCleanAPI.Application.DTOs;
using MyCleanAPI.Domain.Entities;

namespace MyCleanAPI.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
