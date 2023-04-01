using DataAccesWithEFCore.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesWithEFCore.Infrastructure.Abstract
{
    public interface IVendorInformationRepositoryEF
    {
        List<Vendor> GetAllVendors();
    }
}
