using AutoMapper;
using DataAnnotations.Application.Dtos.User;
using DataAnnotations.Domain.Models;

namespace DataAnnotations.Application.Mapping
{
    public class UserMapper : Profile
    {
        public UserMapper() 
        {
            CreateMap<CreateUserDto, UserModel>();
            CreateMap<UserModel, GetUserDto>();
        }
    }
}
