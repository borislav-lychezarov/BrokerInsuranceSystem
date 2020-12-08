namespace BrokerInsuranceSystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class PropertyInsuranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
