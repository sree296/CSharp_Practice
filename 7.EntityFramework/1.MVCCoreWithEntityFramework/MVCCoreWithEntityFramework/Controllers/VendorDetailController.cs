using DataAccesWithEFCore.Infrastructure.Abstract;
using DataAccesWithEFCore.Infrastructure.RepoImplementation;
using DataAccesWithEFCore.RepoModels;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreWithEntityFramework.Controllers
{
    public class VendorDetailController : Controller
    {
        IVendorInformationRepositoryEF _obj = new VendorInformationRepositoryEF();
        public IActionResult Index()
        {
            List<Vendor> vendorsList = _obj.GetAllVendors();

            return View(vendorsList);
        }
    }
}
