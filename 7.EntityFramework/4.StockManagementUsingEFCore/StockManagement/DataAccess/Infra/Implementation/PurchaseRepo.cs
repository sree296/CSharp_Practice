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
    public class PurchaseRepo : IPurchaseRepoInterface
    {
        StockManagementContext _context = new StockManagementContext();

        public List<PurchaseDetails> GetAllPurchases()
        {
            List<PurchaseDetails> purchaseList = new List<PurchaseDetails>();

            try
            {
                purchaseList = _context.PurchaseDetailData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return purchaseList;
        }


        public PurchaseDetails GetPurchaseDetailsById(int purchaseId)
        {
            PurchaseDetails purchaseObj = new PurchaseDetails();

            try
            {
                purchaseObj = _context.PurchaseDetailData.FirstOrDefault(x => x.PurchaseId == purchaseId);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }


            return purchaseObj;
        }

        public string InsertPurchaseDetails(PurchaseDetails purchase)
        {
            string responseMsg = string.Empty;

            try
            {
                Products currnetProd = _context.ProductsData.FirstOrDefault(x => x.ProductId == purchase.ProductId);
                currnetProd.StockQty = purchase.PurchaseQty;

                _context.ProductsData.Update(currnetProd);
                _context.PurchaseDetailData.Add(purchase);
                _context.SaveChanges();

                if (purchase.PurchaseId > 0)
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

        public string UpdatePurchaseDetails(PurchaseDetails purchase)
        {
            string responseMsg = string.Empty;

            try
            {
                PurchaseDetails currentPurchase = _context.PurchaseDetailData.FirstOrDefault(x => x.PurchaseId == purchase.PurchaseId);

                if (currentPurchase != null)
                {
                    currentPurchase.ProductId = purchase.ProductId;
                    currentPurchase.ProductName = purchase.ProductName;
                    currentPurchase.PurchaseDate = purchase.PurchaseDate;
                    currentPurchase.PurchaseQty = purchase.PurchaseQty;

                    Products currnetProd = _context.ProductsData.FirstOrDefault(x => x.ProductId == purchase.ProductId);
                    currnetProd.StockQty = purchase.PurchaseQty;
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
        public string DeletePurchaseDetailsById(int purchaseId)
        {
            string responseMsg = string.Empty;
            try
            {
                PurchaseDetails currentPurchase = _context.PurchaseDetailData.FirstOrDefault(x => x.PurchaseId == purchaseId);
                if (currentPurchase != null)
                {
                    _context.PurchaseDetailData.Remove(currentPurchase);
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
