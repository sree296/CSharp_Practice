using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using StockManagement.Models;

namespace StockManagement.Controllers
{
    public class SalesDataController : Controller
    {
        ISalesRepoInterface _obj = new SalesRepo();
        IProductRepoInterface _productObj = new ProductRepo();
        public IActionResult Index()
        {
            List<SaleDetails> salesList = _obj.GetAllSales();

            return View(salesList);
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            SaleDetails salesObj = _obj.GetSalesDetailsById(Convert.ToInt32(id));

            return View(salesObj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            SalesInfo saleDetailsView = new SalesInfo();

            List<Products> productList = _productObj.GetProducts();
            saleDetailsView.ProductList = productList;

            return View(saleDetailsView);
        }

        [HttpPost]
        public IActionResult Create(SaleDetails salesObj)
        {
            string msg = _obj.InsertSalesDetails(salesObj);

            if (msg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            SaleDetails salesObj = _obj.GetSalesDetailsById(Convert.ToInt32(id));

            return View(salesObj);
        }

        [HttpPost]
        public IActionResult Edit(SaleDetails salesObj)
        {
            string responseMsg = _obj.UpdateSalesDetails(salesObj);

            if (responseMsg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            string responseMsg = _obj.DeleteSalesDetailsById(Convert.ToInt32(id));
            if (responseMsg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
