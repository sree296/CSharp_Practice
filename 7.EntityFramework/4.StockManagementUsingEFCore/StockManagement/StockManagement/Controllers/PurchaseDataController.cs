using DataAccess.Infra.Abstract;
using DataAccess.Infra.Implementation;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace StockManagement.Controllers
{
    public class PurchaseDataController : Controller
    {
        IPurchaseRepoInterface _obj = new PurchaseRepo();
        public IActionResult Index()
        {
            List<PurchaseDetails> purhcaseList = _obj.GetAllPurchases();

            return View(purhcaseList);
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            PurchaseDetails purchaseObj = _obj.GetPurchaseDetailsById(Convert.ToInt32(id));

            return View(purchaseObj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PurchaseDetails purchase)
        {
            string msg = _obj.InsertPurchaseDetails(purchase);

            if (msg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            PurchaseDetails purchaseObj = _obj.GetPurchaseDetailsById(Convert.ToInt32(id));

            return View(purchaseObj);
        }

        [HttpPost]
        public IActionResult Edit(PurchaseDetails purchaseObj)
        {
            string responseMsg = _obj.UpdatePurchaseDetails(purchaseObj);

            if (responseMsg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            string responseMsg = _obj.DeletePurchaseDetailsById(Convert.ToInt32(id));
            if (responseMsg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
