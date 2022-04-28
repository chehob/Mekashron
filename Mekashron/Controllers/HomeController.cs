using Mekashron.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace Mekashron.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            ICUTechservice.ICUTechClient client = new ICUTechservice.ICUTechClient();

            var result = await client.LoginAsync(request.UserName, request.Password, "");
            if (result == null)
            {
                return NotFound();
            }

            var loginResponse = JsonSerializer.Deserialize<LoginResponse>(result.@return);
            if (loginResponse == null)
            {
                return NotFound();
            }

            return Json(loginResponse);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}