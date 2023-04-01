using DataAccesWithEFCore.Infrastructure.Abstract;
using DataAccesWithEFCore.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesWithEFCore.Infrastructure.RepoImplementation
{
    public class VendorInformationRepositoryEF : IVendorInformationRepositoryEF
    {
        VendorManagementContext _context = new VendorManagementContext();
        public List<Vendor> GetAllVendors()
        {
            List<Vendor> vendorsList = new List<Vendor>();

            try
            {
                vendorsList = _context.VendorDetailData.ToList();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }


            return vendorsList;
        }
    }
}
