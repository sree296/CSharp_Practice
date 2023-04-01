using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace MultipleModelEFCore.Controllers
{
    public class ProductVendorController : Controller
    {
        IProductInfoRepository _obj = new ProductInfoRepository();
        [HttpGet]
        public IActionResult GetProductsAndVendors()
        {
            ProductVendor objData = _obj.GetProductVendors();

            return View(objData);
        }
    }
}
