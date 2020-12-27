using BrokerInsuranceSystem.Areas.TheBoss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrokerInsuranceSystem.Areas.TheBoss.Services.User
{
    public interface IUserService
    {
        Task CreateUser(CreateUserModelDto model);

        Task EditUserInfo(EditUserModelDto model);

        Task DeleteUser(string userId);
    }
}
