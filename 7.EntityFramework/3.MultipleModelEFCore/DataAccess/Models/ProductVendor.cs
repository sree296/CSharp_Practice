using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ProductVendor
    {
        public List<VendorInfo> VendorsList { get; set; }
        public List<Product> ProductsList { get; set; }

    }
}
