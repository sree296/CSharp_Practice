using DataAccess.Context;
using DataAccess.Infra.Abstract;
using DataAccess.Models;

namespace DataAccess.Infra.Implementation
{
    public class ProductInfoRepository : IProductInfoRepository
    {
        ProductManagementContext _context = new ProductManagementContext();
        
        public ProductVendor GetProductVendors()
        {
            ProductVendor prodObj = new ProductVendor();
            List<VendorInfo> vendorsList = _context.VendorDetailData.ToList();
            List<Product> productsList = _context.ProductData.ToList();

            prodObj.VendorsList = vendorsList;
            prodObj.ProductsList = productsList;

            return prodObj;
        }
    }
}
