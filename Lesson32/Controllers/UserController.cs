using Lesson32.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ShopLib;
using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Lesson32.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            //ViewData["IsAuthorize"] = User?.Identity?.IsAuthenticated ?? false;
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewData["IsLoginCorrect"] = false;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model, string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                Context shopContext = new Context();
                var isExists  = shopContext.Users
                    .Any(u => u.Email == model.Email && u.Password == model.Password);
                //ViewData["IsLoginCorrect"] = isExists;
                //ViewBag.Email = model.Email;
                //ViewBag.Password = model.Password;
                if (isExists)
                {
                    var claims = new List<Claim> { new Claim(ClaimTypes.Name, model.Email) };
                    // создаем объект ClaimsIdentity
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");
                    // установка аутентификационных куки
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return Redirect(returnUrl ?? "/");
                }
                else
                {
                    return Unauthorized();
                }
            }
            else
            {
                return BadRequest("Login or password is not correct.");
            }
        }
        public IActionResult Registration()
        {
            ViewData["IsRegistrationCorrect"] = false;
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                Context shopContext = new Context();

                shopContext.Users.Add(new ShopLib.Models.User(
                    model.FirstName, model.LastName, model.Age,
                    model.Gender, model.Address, model.Email, model.Password));
                shopContext.SaveChanges();

                ViewData["IsRegistrationCorrect"] = true;
            }
            else
            {
                ViewData["IsRegistrationCorrect"] = false;
            }                
            return View();
        }
    }
}
