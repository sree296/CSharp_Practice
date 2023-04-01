using MVC_Core_ADO_NET_Repository_Pattern.Models;

namespace MVC_Core_ADO_NET_Repository_Pattern.Repository
{
    public interface IVendorRepository
    {
        List<Vendor> getVendorDetails();
    }
}
