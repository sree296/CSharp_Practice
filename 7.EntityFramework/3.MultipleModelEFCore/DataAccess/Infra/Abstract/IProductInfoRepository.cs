using DataAccess.Models;

namespace DataAccess.Infra.Abstract
{
    public interface IProductInfoRepository
    {
        ProductVendor GetProductVendors();
    }
}
