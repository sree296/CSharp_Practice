using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompetencyAssessment.Controllers
{
    // [Authorize]
    public class AuthRedirectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult DeleteData()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EditData()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult DisplayData()
        {
            return View();
        }
    }
}
