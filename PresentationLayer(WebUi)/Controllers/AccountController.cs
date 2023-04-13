using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.AspNetCore.Authorization;
using MailKit.Net.Smtp;
using MimeKit;
using AutoMapper;
using SharedLayer.Domain.Models.Entities;
using System.Threading.Tasks;
using SharedLayer.Domain.ViewModels;
using System.Linq;

namespace EcommerceApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IMapper _mapper;
        private string From = "ayaahmed199910@gmail.com";
        private string Password = "wdoxhzsfsqlymiod";
        public AccountController(IMapper mapper, UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            this.userManager = _userManager;
            this.signInManager = _signInManager;
            _mapper = mapper;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid == true)
            {
                var userModel = _mapper.Map<ApplicationUser>(registerVM);


                var emailcheck = await userManager.FindByEmailAsync(userModel.Email);
                if (emailcheck == null)
                {
                    IdentityResult result = await userManager.CreateAsync(userModel, userModel.PasswordHash);
                    if (result.Succeeded)
                    {

                        await userManager.AddToRoleAsync(userModel, "User");


                        var callbackUrl = Url.Action("ConfirmEmail", "Account",
                            new { userId = userModel.Id, token = await userManager.GenerateEmailConfirmationTokenAsync(userModel) }, protocol: HttpContext.Request.Scheme);

                        var subject = "Confirm your email";
                        var body = $"Please confirm your email address by clicking this link: <a href='{callbackUrl}'>link</a>";


                        var email = new MimeMessage();
                        email.From.Add(MailboxAddress.Parse(From));
                        email.To.Add(MailboxAddress.Parse(userModel.Email));
                        email.Subject = subject;
                        email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

                        using var smtp = new SmtpClient();
                        smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                        smtp.Authenticate(From, Password);
                        smtp.Send(email);
                        smtp.Disconnect(true);

                        return RedirectToAction("ConfirmEmailSent");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);

                        }
                    }
                }
                else
                {
                    TempData["Emailfound"] = "This Email Already Exisit";
                    TempData["alertType"] = "Error";
                }
            }

            return View(registerVM);
        }


        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userModel = await userManager.FindByEmailAsync(model.Email);
                if (userModel == null)
                {
                    return View(model);
                }

                var callbackUrl = Url.Action("ResetPassword", "Account",
                    new { token = await userManager.GeneratePasswordResetTokenAsync(userModel) }, protocol: HttpContext.Request.Scheme);

                var emailSubject = "Reset your password";
                var emailBody = $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>";


                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(From));
                email.To.Add(MailboxAddress.Parse(userModel.Email));
                email.Subject = emailSubject;
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = emailBody };

                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(From, Password);
                smtp.Send(email);
                smtp.Disconnect(true);

                return View("ForgotPasswordConfirmation");
            }

            return View(model);
        }

        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string token = null)
        {
            if (token == null)
            {
                return BadRequest("A token is required for password reset.");
            }

            var model = new ResetPasswordViewModel { Token = token };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return View(model);
            }

            var result = await userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return BadRequest("Invalid user ID.");
            }

            var result = await userManager.ConfirmEmailAsync(user, token);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors.FirstOrDefault()?.Description);
            }

            return RedirectToAction("Login");
        }
        public IActionResult ConfirmEmailSent()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await userManager.FindByNameAsync(loginVM.UserName);

                if (user != null)
                {
                    if (!await userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError("", "Please confirm your email address before logging in.");
                        return View(loginVM);
                    }

                    var result = await signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememebrMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError("", "Error In UserName Or Password");
            }

            return View(loginVM);
        }
        public IActionResult Logout()
        {
            signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }

}