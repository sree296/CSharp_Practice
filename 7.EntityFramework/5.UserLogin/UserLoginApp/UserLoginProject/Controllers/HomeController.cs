using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserLoginProject.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace UserLoginProject.Controllers
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
            string uName = HttpContext.Session.GetString("UserName");
            if (uName == null)
            {
                return RedirectToAction("SubmitUser", "UserLogin");
            }

            ViewBag.User = uName;
            return View();
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