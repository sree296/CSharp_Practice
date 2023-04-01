using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using UserFormApp.Models;

namespace UserFormApp.Controllers
{
    public class UserFormController : Controller
    {
        IUserDetailsRepo _userObj = new UserDetailsRepo();
       
        [HttpGet]
        public IActionResult Index()
        {
            UserDetail userDetailsView = new UserDetail();

            List<CountryDetail> countryList = _userObj.GetCountryDetails();
            List<LanguageDetail> langList = _userObj.GetLanguageDetails();

            userDetailsView.CountriesInfo = countryList;
            userDetailsView.LanguagesInfo = langList;

            return View(userDetailsView);
        }

        [HttpPost]
        public IActionResult Index(UserDetail userDetails)
        {
            Console.WriteLine(userDetails);
            /* Post Code Here */

            return View();
        }
    }
}
