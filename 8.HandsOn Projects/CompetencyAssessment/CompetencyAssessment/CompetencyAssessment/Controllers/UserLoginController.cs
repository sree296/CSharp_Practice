using BusinessEntity.BEModels;
using CARepository.Abstract;
using CARepository.Implementation;
using CARepository.RepoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompetencyAssessment.Controllers
{
    public class UserLoginController : Controller
    {
        IUserDetailsRepo _obj = new UserDetailsRepo();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LoginSubmit()
        {
            HttpContext.Session.SetString("UserName", String.Empty);
            return View();
        }

        [HttpPost]
        public IActionResult LoginSubmit(LoginViewModel loginViewModel)
        {
            UserInfo userObj = _obj.SubmitUserLogin(loginViewModel);

            if(userObj.UserId != null)
            {
                HttpContext.Session.SetString("UserName", userObj.Name);
                return RedirectToAction("Index", "Home");

            }

            return View();
        }

        [HttpGet]
        public IActionResult RegisterUser()
        {
            RegisterViewModel registerView = new RegisterViewModel();

            List<RoleDetail> rolesList = _obj.GetRoleDetails();

            registerView.RolesInfo = rolesList;

            return View(registerView);
        }

        [HttpPost]
        public IActionResult RegisterUser(RegisterViewModel registerView)
        {
            if (ModelState.IsValid)
            {
                string createBy = HttpContext.Session.GetString("UserName");
                registerView.CreatedBy = createBy;

                string msg = _obj.RegisterNewUser(registerView);

                if (msg.Trim().ToLower().Equals("success"))
                {
                    return RedirectToAction("Index", "Home");
                }

                ViewData["UserCreateMsg"] = msg;
            }

            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordModel changePswdViewModel)
        {
            string modifiedBy = HttpContext.Session.GetString("UserName");

            if (modifiedBy != String.Empty)
            {
                changePswdViewModel.ModifiedBy = modifiedBy;
            }
            
            UserInfo userObj = _obj.ChangePassword(changePswdViewModel);
            if(userObj != null)
            {
               return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
