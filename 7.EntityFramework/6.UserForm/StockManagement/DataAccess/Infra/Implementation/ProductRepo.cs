using DataAccess.Context;
using DataAccess.Infra.Abstract;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Implementation
{
    public class ProductRepo : IProductRepoInterface
    {
        StockManagementContext _context = new StockManagementContext();
        public List<Products> GetProducts()
        {
            List<Products> productList = new List<Products>();

            try
            {
                productList = _context.ProductsData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return productList;
        }
    }
}
