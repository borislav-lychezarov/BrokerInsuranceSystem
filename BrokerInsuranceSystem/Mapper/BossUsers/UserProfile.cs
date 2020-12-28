using AutoMapper;
using BrokerInsuranceSystem.Areas.TheBoss.Models;
using DatabaseModels.Models.User;

namespace BrokerInsuranceSystem.Mapper.BossUsers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            this.CreateMap<ApplicationUser, GetAllUsersModelDto>();
            this.CreateMap<ApplicationUser, UserModelDto>()
                .ReverseMap();
        }
    }
}
