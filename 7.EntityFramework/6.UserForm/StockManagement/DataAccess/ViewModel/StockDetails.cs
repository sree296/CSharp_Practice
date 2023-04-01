using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.ViewModel
{
    public class StockDetails
    {
        public List<PurchaseDetails> PurchaseList { get; set; }
        public List<SaleDetails> SaleList { get; set; }
        public List<Products> ProductList { get; set; }
    }
}
