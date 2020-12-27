using AutoMapper;
using BrokerInsuranceSystem.Models.BossAreaModels;
using Microsoft.AspNetCore.Identity;

namespace BrokerInsuranceSystem.Mapper.BossUsers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            this.CreateMap<IdentityUser, GetAllUsersModelDto>();
            this.CreateMap<IdentityUser, UserModelDto>();
        }
    }
}
