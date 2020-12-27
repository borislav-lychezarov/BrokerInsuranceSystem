using BrokerInsuranceSystem.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrokerInsuranceSystem.Controllers
{
    [Authorize(Roles =nameof(RoleTypes.Employee))]
    public class CarInsuranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllCascoInsurances()
        {
            return View();
        }

        public IActionResult GetAllThirdPartLiabilities()
        {
            return View();
        }

        public IActionResult GetAllCarAssistances()
        {
            return View();
        }
    }
}
