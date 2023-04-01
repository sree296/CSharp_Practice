using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace StockManagement.Controllers
{
    public class StockInfoController : Controller
    {
        IStockManagementRepo _obj = new StockManagementRepo();

        [HttpGet]
        public IActionResult GetStockAndPurchaseDetails()
        {
            StockDetails objData = _obj.GetStockDetails();

            return View(objData);
        }
    }
}
