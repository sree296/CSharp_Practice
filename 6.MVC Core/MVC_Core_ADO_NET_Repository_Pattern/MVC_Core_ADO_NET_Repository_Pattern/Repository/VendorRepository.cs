using MVC_Core_ADO_NET_Repository_Pattern.Models;
using System.Data.SqlClient;
using System.Data;

namespace MVC_Core_ADO_NET_Repository_Pattern.Repository
{
    public class VendorRepository : IVendorRepository
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-121UAJH; Database=INVENTORY_MANAGEMENT; Integrated Security=true");
        public List<Vendor> getVendorDetails()
        {
            List<Vendor> vendorList = new List<Vendor>();

            try
            {
                SqlCommand com = new SqlCommand("GetVendorDetails", con);
                com.CommandType = CommandType.StoredProcedure;

                // step-3
                DataTable vendorDataTable = new DataTable();

                // step-4
                SqlDataAdapter dataAdap = new SqlDataAdapter(com);
                dataAdap.Fill(vendorDataTable);

                if(vendorDataTable.Rows.Count > 0)
                {
                    foreach(DataRow row in vendorDataTable.Rows)
                    {
                        Vendor vendor = new Vendor();
                        vendor.VID = Convert.ToInt32(row["VID"]);
                        vendor.VName = row["VName"].ToString();
                        vendor.Address = row["Address"].ToString();
                        vendor.CityID = Convert.ToInt32(row["CityID"]);
                        vendorList.Add(vendor);
                    }
                }

            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }

            return vendorList;
        }
    }
}
