using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreWithEntityFWCrud.Controllers
{
    public class VendorDetailController : Controller
    {
        IVendorInfoRepository _obj = new VendorInfoRepository();
        public IActionResult Index()
        {

            List<VendorInfo> lst = _obj.GetAllVendors();

            return View(lst);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VendorInfo vendor)
        {
            string msg = _obj.InsertVerdorInfo(vendor);

            if (msg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            VendorInfo vendor = _obj.GetVendorByVId(Convert.ToInt32(id));

            return View(vendor);
        }

        [HttpPost]
        public IActionResult Edit(VendorInfo vendor)
        {
            string responseMsg = _obj.UpdateVendor(vendor);

            if (responseMsg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            VendorInfo vendor = _obj.GetVendorByVId(Convert.ToInt32(id));

            return View(vendor);
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            string responseMsg = _obj.DeleteVendorByVendorId(Convert.ToInt32(id));
            if (responseMsg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
