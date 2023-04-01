using Microsoft.AspNetCore.Mvc;
using MVC_Core_ADO_NET_Repository_Pattern.Models;
using MVC_Core_ADO_NET_Repository_Pattern.Repository;

namespace MVC_Core_ADO_NET_Repository_Pattern.Controllers
{
    public class VendorDetailController : Controller
    {
        IVendorRepository vendorRepository = new VendorRepository();
        public IActionResult Index()
        {
           List<Vendor> vendorList = vendorRepository.getVendorDetails();
            return View(vendorList);
        }
    }
}
