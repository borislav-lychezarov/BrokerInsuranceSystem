using BrokerInsuranceSystem.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BrokerInsuranceSystem.Areas.TheBoss.Controllers
{
    [Area("TheBoss")]
    [Authorize(Roles = nameof(RoleTypes.Admin))]
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
