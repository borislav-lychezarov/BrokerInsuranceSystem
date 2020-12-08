using AutoMapper;
using AutoMapper.QueryableExtensions;
using BrokerInsuranceData;
using BrokerInsuranceSystem.Mapper.BossUsers;
using BrokerInsuranceSystem.Models.BossAreaModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BrokerInsuranceSystem.Areas.TheBoss.Controllers
{
    [Area("TheBoss")]
    public class UserController : Controller
    {
        private readonly BrokerInsuranceDatabase context;
        private readonly IMapper mapper;

        public UserController(BrokerInsuranceDatabase context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var users = this.context.Users
                .ProjectTo<GetAllUsersModelDto>(this.mapper.ConfigurationProvider)
                .ToList();

            return View(users);
        }

        public IActionResult EditUser(string id)
        {
            var user = this.context.Users
                .ProjectTo<UserModelDto>(this.mapper.ConfigurationProvider)
                .FirstOrDefault(x => x.Id == id);

            return View(user);

            
        }

        public IActionResult DeleteUser(string id)
        {

            return this.RedirectToAction(nameof(Index));
        }



    }
}
