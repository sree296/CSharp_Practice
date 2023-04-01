using DataAccessRepository.Abstract;
using Microsoft.AspNetCore.Mvc;
using DataAccessRepository.Repo;
using DataAccessRepository.DataModels;


namespace TwoTierMVCCoreADONETRepositoryPattern.Controllers
{
    public class ProductDetailsController : Controller
    {

        ISaveProductDetailsRepository saveProductDetails = new SaveProductDetailsRepository();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(
            string PName,
            decimal PPrice,
            int StockQty,
            int VID
        )
        {
            var result = saveProductDetails.InsertProductData(PName, PPrice, StockQty, VID);
            return View();
        }
    }
}
