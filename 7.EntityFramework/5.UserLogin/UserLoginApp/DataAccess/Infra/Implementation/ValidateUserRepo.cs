using DataAccess.Context;
using DataAccess.Infra.Abstract;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infra.Implementation
{
    public class ValidateUserRepo : IValidateUserRepo
    {
        UserLoginContext _context = new UserLoginContext();

        public string CheckForValidUser(UserDetails userInfo)
        {
            var responseMsg = String.Empty;

            UserDetails userObj = new UserDetails();

            try
            {
                userObj = _context.UserDetailsData.FirstOrDefault(x => (x.userName == userInfo.userName && x.userPassword == userInfo.userPassword));
                if(userObj == null)
                {
                    responseMsg = "Login Failed, Please check User Name and Password";
                }else
                {
                    responseMsg = "success";
                }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return responseMsg;
        }

        public string CreateNewUser(UserDetails userInfo)
        {
            string responseMsg = string.Empty;
            UserDetails oldUser = _context.UserDetailsData.FirstOrDefault(x => x.userName == userInfo.userName);
            
            if (oldUser != null)
            {
                responseMsg = "User Already Exist";
            }
            else
            {
                try
                {
                    _context.UserDetailsData.Add(userInfo);
                    _context.SaveChanges();

                    if (userInfo.userName != null)
                    {
                        responseMsg = "success";
                    }
                    else
                    {
                        responseMsg = "Create User Failed";
                    }
                }
                catch (Exception ex)
                {
                    responseMsg = ex.Message;
                }
            }

            return responseMsg;
        }
    }
}
