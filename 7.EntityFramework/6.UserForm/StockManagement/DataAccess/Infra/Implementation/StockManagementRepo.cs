using DataAccess.Context;
using DataAccess.Infra.Abstract;
using DataAccess.Models;
using DataAccess.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Implementation
{
    public class StockManagementRepo : IStockManagementRepo
    {
        StockManagementContext _context = new StockManagementContext();
        public StockDetails GetStockDetails()
        {
            StockDetails stockObj = new StockDetails();
            List<PurchaseDetails> purchaseList = _context.PurchaseDetailData.ToList();
            List<SaleDetails> salesList = _context.SalesData.ToList();
            List<Products> productList = _context.ProductsData.ToList();

            stockObj.PurchaseList  = purchaseList;
            stockObj.SaleList = salesList;
            stockObj.ProductList = productList;

            return stockObj;
        }
    }
}
