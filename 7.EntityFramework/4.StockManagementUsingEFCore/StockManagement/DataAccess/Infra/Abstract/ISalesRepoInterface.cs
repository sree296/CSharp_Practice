using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Abstract
{
    public interface ISalesRepoInterface
    {
        List<SaleDetails> GetAllSales();
        string InsertSalesDetails(SaleDetails sales);
        string UpdateSalesDetails(SaleDetails sales);
        SaleDetails GetSalesDetailsById(int saleId);
        string DeleteSalesDetailsById(int saleId);
    }
}
