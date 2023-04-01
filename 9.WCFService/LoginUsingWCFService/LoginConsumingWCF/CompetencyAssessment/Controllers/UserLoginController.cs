using BusinessEntity.BEModels;
using CARepository.Abstract;
using CARepository.Implementation;
using CARepository.RepoModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using MyWCFLoginService;

namespace CompetencyAssessment.Controllers
{
    public class UserLoginController : Controller
    {
        IUserDetailsRepo _obj = new UserDetailsRepo();


        [HttpGet]
        public IActionResult LoginSubmit()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginSubmit(LoginViewModel loginViewModel)
        {
            UserLoginServiceClient _myObj = new UserLoginServiceClient();
            if (ModelState.IsValid)
            {

                var _serviceObj = await _myObj.UserLoginSubmitAsync(loginViewModel.UserId, loginViewModel.Password);
               
                if(_serviceObj != null)
                {
                    Console.WriteLine("User Info Collected from WCF Service");

                }

                UserDetails userObj = _obj.SubmitUserLogin(loginViewModel);

                if (userObj == null)
                {
                    return RedirectToAction("MyInstruction");
                }
                else
                {
                    string[] userRoles = new string[] { userObj.RoleName };

                    var claims = new List<Claim>();
                    claims.Add(new Claim("username", userObj.UserId));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, userObj.UserId));
                    foreach (var eachRole in userRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, eachRole));
                    }

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);

                    return RedirectToAction("DeleteData", "AuthRedirect");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(UserDetails userDetails)
        {
            if (ModelState.IsValid)
            {
                string msg = _obj.CreateNewUser(userDetails);

                if (msg.Trim().ToLower().Equals("success"))
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        public IActionResult MyInstruction()
        {
            return View();
        }

    }
}
