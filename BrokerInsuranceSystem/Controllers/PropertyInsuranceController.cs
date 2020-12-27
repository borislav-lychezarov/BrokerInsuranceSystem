namespace BrokerInsuranceSystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class PropertyInsuranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
