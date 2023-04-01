using DataAccessRepository.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessRepository.Abstract
{
    public interface ISaveProductDetailsRepository
    {

        List<Product> InsertProductData(
            string PName,
            decimal PPrice,
            int StockQty,
            int VID
            );
    }
}
