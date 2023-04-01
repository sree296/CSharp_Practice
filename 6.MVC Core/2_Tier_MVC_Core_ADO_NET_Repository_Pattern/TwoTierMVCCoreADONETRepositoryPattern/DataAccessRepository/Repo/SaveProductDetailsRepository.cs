using DataAccessRepository.Abstract;
using DataAccessRepository.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace DataAccessRepository.Repo
{
    public class SaveProductDetailsRepository : ISaveProductDetailsRepository
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-121UAJH; Database=INVENTORY_MANAGEMENT; Integrated Security=true");
        public List<Product> InsertProductData(string PName, decimal PPrice, int StockQty, int VID)
        {

            List<Product> productList = new List<Product>();
            try
            {
                SqlCommand com = new SqlCommand("InsertProdutData", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@PName", PName);
                com.Parameters.AddWithValue("@PPrice", PPrice);
                com.Parameters.AddWithValue("@StockQty", StockQty);
                com.Parameters.AddWithValue("@VID", VID);

                con.Open();
                int response = com.ExecuteNonQuery();
                con.Close();

                if(response > 0)
                {
                    Console.WriteLine("Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            return productList;
        }
    }
}
