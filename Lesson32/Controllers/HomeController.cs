using Lesson32.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ShopLib;
using Microsoft.AspNetCore.Authorization;

namespace Lesson32.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //ViewData["IsAuthorize"] = User?.Identity?.IsAuthenticated ?? false;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Order()
        {
            Context shopContext = new Context();
            var users = shopContext.Users.ToList();
            ViewData["Users"] = users;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Order(OrderModel model)
        {
            Context shopContext = new Context();
            if (ModelState.IsValid)
            {                
                shopContext.Orders.Add(new ShopLib.Models.Order(model.UserId, model.Info));
                shopContext.SaveChanges();
                return View("SavedSuccessfully");
            }

            var users = shopContext.Users.ToList();
            ViewData["Users"] = users;
            return View();
        }

        [Authorize]
        public IActionResult Question()
        {
            Context shopContext = new Context();
            var users = shopContext.Users.ToList();
            ViewData["Users"] = users;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Question(QuestionModel model)
        {
            Context shopContext = new Context();
            if (ModelState.IsValid)
            {
                shopContext.Questions.Add(new ShopLib.Models.Question(model.UserId, model.Title, model.Text));
                shopContext.SaveChanges();
                return View("SavedSuccessfully");
            }

            var users = shopContext.Users.ToList();
            ViewData["Users"] = users;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}