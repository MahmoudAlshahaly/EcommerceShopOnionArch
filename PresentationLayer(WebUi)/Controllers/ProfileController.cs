using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharedLayer.Domain.Models.Entities;
using SharedLayer.Domain.ViewModels;
using System.Threading.Tasks;

namespace EcommerceApp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IMapper _mapper;

        public ProfileController(IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            this.userManager = userManager;
        }

        public IActionResult Profile()
        {
            return View();
        }

        public async Task<IActionResult> PersonalData()
        {
            var currentUser = await userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound();
            }

            var userData = await userManager.FindByIdAsync(currentUser.Id);

            var userModel = _mapper.Map<RegisterVM>(userData);

            return PartialView(userModel);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser()
        {
            var model = await userManager.GetUserAsync(User);

            if (model == null)
            {
                return NotFound();
            }
            var user = _mapper.Map<RegisterVM>(model);

            return PartialView(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Error updating user data.";
                return RedirectToAction("Profile");
            }

            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound();
            }

            var newPasswordHash = userManager.PasswordHasher.HashPassword(user, model.Password);

            user.FullName = model.FullName;
            user.Gender = model.Gender;
            user.Address = model.Address;
            user.BirthDate = model.BirthDate;
            user.Email = model.Email;
            user.UserName = model.UserName;
            user.PasswordHash = newPasswordHash;


            var result = await userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                TempData["Error"] = "Error updating user data.";
                return RedirectToAction("Profile");

            }

            return RedirectToAction("Profile");
        }
    }
}