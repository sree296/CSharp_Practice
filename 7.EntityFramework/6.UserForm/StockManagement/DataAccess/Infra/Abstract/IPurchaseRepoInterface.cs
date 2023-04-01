using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Abstract
{
    public interface IPurchaseRepoInterface
    {
        List<PurchaseDetails> GetAllPurchases();
        string InsertPurchaseDetails(PurchaseDetails purchase);
        string UpdatePurchaseDetails(PurchaseDetails purchase);
        PurchaseDetails GetPurchaseDetailsById(int purchaseId);
        string DeletePurchaseDetailsById(int purchaseId);
    }
}
