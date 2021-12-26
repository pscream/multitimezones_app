using System;

using AutoMapper;

using UserResponse = WebApi.Models.Responses.User;
using UserDatabase = WebApi.Models.Database.User;

namespace WebApi.Models.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDatabase, UserResponse>();
        }
    }
}