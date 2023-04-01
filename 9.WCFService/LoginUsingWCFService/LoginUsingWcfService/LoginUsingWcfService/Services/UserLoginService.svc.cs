using LoginUsingWcfService.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace LoginUsingWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserLoginService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserLoginService.svc or UserLoginService.svc.cs at the Solution Explorer and start debugging.
    public class UserLoginService : IUserLoginService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conString"]);

        public UserInfo UserLoginSubmit(string userId, string password)
        {
            UserInfo userRes = new UserInfo();
            SqlCommand com = new SqlCommand("GetUserInfoByUserId", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@UserId", userId);
            com.Parameters.AddWithValue("@Password", password);

            DataTable dtData = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dtData);


                if (dtData.Rows.Count == 1)
                {
                    userRes.UserId = dtData.Rows[0]["UserId"].ToString();
                    userRes.Name = dtData.Rows[0]["Name"].ToString();
                    userRes.EmpID = dtData.Rows[0]["EmpID"].ToString();
                    userRes.Email = dtData.Rows[0]["Email"].ToString();
                    userRes.SuccessMessage = "User Data collected successfully";

                }
                else
                {
                    userRes.SuccessMessage = "Invalid operation";
                }

            }
            catch (Exception ex)
            {
                userRes.SuccessMessage = "Some Exception";
            }

            return userRes;
        }
    }
}
