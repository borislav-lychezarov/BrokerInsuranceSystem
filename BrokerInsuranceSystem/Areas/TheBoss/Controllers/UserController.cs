using AutoMapper;
using AutoMapper.QueryableExtensions;
using BrokerInsuranceData;
using BrokerInsuranceSystem.Areas.TheBoss.Models;
using BrokerInsuranceSystem.Enums;
using BrokerInsuranceSystem.Models;
using DatabaseModels.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BrokerInsuranceSystem.Areas.TheBoss.Controllers
{
    [Area("TheBoss")]
    [Authorize(Roles = nameof(RoleTypes.Admin))]
    public class UserController : Controller
    {
        private readonly BrokerInsuranceDatabase context;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(BrokerInsuranceDatabase context,
            IMapper mapper,
            UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
        }
        public IActionResult GetAllUsers()
        {
            var currentUserId = this.User.Claims
                .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
            var users = this.context.Users
                .Where(x => x.Id != currentUserId.Value)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserAsync(UserModelDto model)
        {
            try
            {
                ApplicationUser user = await this.userManager
                    .FindByIdAsync(model.Id);
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.PhoneNumber = model.PhoneNumber;

                await this.userManager.UpdateAsync(user);

                return this.RedirectToAction(nameof(GetAllUsers));
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return this.Content(ex.Message);

            }
            catch (DbUpdateException ex)
            {
                return this.Content(ex.Message);

            }
            catch (Exception ex)
            {

                return this.Content(ex.Message);
            }

        }

        public async Task<IActionResult> DeleteUserAsync(string id)
        {
            var user = this.context.Users
                .Find(id);
            var result = await this.userManager.DeleteAsync(user);
            
            return this.RedirectToAction(nameof(GetAllUsers));
        }

        public IActionResult CreateUser()
        {
            return View(new CreateUserModelDto());
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(CreateUserModelDto model)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }
            ApplicationUser user = new ApplicationUser()
            {
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var roleResult = await this.userManager.AddToRoleAsync(user, RoleTypes.Employee.ToString());
                if (!roleResult.Succeeded)
                {
                    return RedirectToAction(nameof(EditUser), new { id = user.Id });
                }
                return RedirectToAction(nameof(GetAllUsers));
            }
            else
            {
                return this.View(model);
            }

        }



    }
}
