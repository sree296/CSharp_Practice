using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;


namespace UserLoginProject.Controllers
{
    public class UserLoginController : Controller
    {
        IValidateUserRepo _obj = new ValidateUserRepo();


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SubmitUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitUser(UserDetails userData)
        {
            if (ModelState.IsValid)
            {
                string msg = _obj.CheckForValidUser(userData);

                if (msg.Trim().ToLower().Equals("success"))
                {
                    HttpContext.Session.SetString("UserName", userData.userName);
                    return RedirectToAction("Index", "Home");
                }

                ViewData["LoginMsg"] = msg;
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(UserDetails userData)
        {
            if (ModelState.IsValid)
            {
                string msg = _obj.CreateNewUser(userData);

                if (msg.Trim().ToLower().Equals("success"))
                {
                    return RedirectToAction("SubmitUser", "UserLogin");
                }

                ViewData["UserCreateMsg"] = msg;
            }

            return View();
        }
    }
}
