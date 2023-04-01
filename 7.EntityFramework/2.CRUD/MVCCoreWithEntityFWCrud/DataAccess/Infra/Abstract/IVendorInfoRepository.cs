using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Abstract
{
    public interface IVendorInfoRepository
    {
        List<VendorInfo> GetAllVendors();
        string InsertVerdorInfo(VendorInfo vendor);
        string UpdateVendor(VendorInfo vendor);
        VendorInfo GetVendorByVId(int vendorId);
        string DeleteVendorByVendorId(int vendorId);
    }
}
