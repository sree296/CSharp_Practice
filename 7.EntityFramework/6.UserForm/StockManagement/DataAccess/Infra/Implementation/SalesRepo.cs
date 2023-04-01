using DataAccess.Context;
using DataAccess.Infra.Abstract;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Implementation
{
    public class SalesRepo : ISalesRepoInterface
    {
        StockManagementContext _context = new StockManagementContext();

        public List<SaleDetails> GetAllSales()
        {
            List<SaleDetails> salesList = new List<SaleDetails>();

            try
            {
                salesList = _context.SalesData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return salesList;
        }


        public SaleDetails GetSalesDetailsById(int saleId)
        {
            SaleDetails saleObj = new SaleDetails();

            try
            {
                saleObj = _context.SalesData.FirstOrDefault(x => x.SalesID == saleId);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }


            return saleObj;
        }

        public string InsertSalesDetails(SaleDetails salesObj)
        {
            string responseMsg = string.Empty;

            try
            {
                Products currnetProd = _context.ProductsData.FirstOrDefault(x => x.ProductId == salesObj.ProductId);
                currnetProd.StockQty = currnetProd.StockQty - salesObj.SalesQty;

                _context.ProductsData.Update(currnetProd);
                _context.SalesData.Add(salesObj);
                _context.SaveChanges();

                if (salesObj.SalesID > 0)
                {
                    responseMsg = "success";
                }
                else
                {
                    responseMsg = "Data Insert Failed";
                }
            }
            catch (Exception ex)
            {
                responseMsg = ex.Message;
            }

            return responseMsg;
        }

        public string UpdateSalesDetails(SaleDetails salesObj)
        {
            string responseMsg = string.Empty;

            try
            {
                SaleDetails currentSale = _context.SalesData.FirstOrDefault(x => x.SalesID == salesObj.SalesID);
                PurchaseDetails currentPurchase = _context.PurchaseDetailData.FirstOrDefault(x => x.ProductId == salesObj.ProductId);
                if (currentSale != null)
                {
                    Products currnetProd = _context.ProductsData.FirstOrDefault(x => x.ProductId == salesObj.ProductId);
                    currnetProd.StockQty = currentPurchase.PurchaseQty - salesObj.SalesQty;

                    currentSale.SalesID = salesObj.SalesID;
                    currentSale.ProductName = salesObj.ProductName;
                    currentSale.SalesDate = salesObj.SalesDate;
                    currentSale.SalesQty = salesObj.SalesQty;
                    _context.SaveChanges();

                    responseMsg = "success";
                }
                else
                {
                    responseMsg = "failed";
                }


            }
            catch (Exception ex)
            {
                responseMsg = "exception";
            }


            return responseMsg;
        }
        public string DeleteSalesDetailsById(int salesId)
        {
            string responseMsg = string.Empty;
            try
            {
                SaleDetails currentSales = _context.SalesData .FirstOrDefault(x => x.SalesID == salesId);
                if (currentSales != null)
                {
                    _context.SalesData.Remove(currentSales);
                    _context.SaveChanges();
                    responseMsg = "success";
                }
                else
                {
                    responseMsg = "failed";
                }

            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return responseMsg;
        }

    }
}
