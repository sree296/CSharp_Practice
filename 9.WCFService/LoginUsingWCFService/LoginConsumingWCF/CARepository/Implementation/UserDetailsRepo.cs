using BusinessEntity.BEModels;
using BusinessEntity.Context;
using CARepository.Abstract;
using CARepository.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.Implementation
{
    public class UserDetailsRepo : IUserDetailsRepo
    {
        CompetencyContext _context = new CompetencyContext();

        public UserDetails SubmitUserLogin(LoginViewModel loginViewModel)
        {
            UserDetails userObj = new UserDetails();

            userObj = _context.UserDetailData.FirstOrDefault(x => x.UserId == loginViewModel.UserId && x.Password == loginViewModel.Password);

            return userObj;
        }

        public string CreateNewUser(UserDetails userInfo)
        {
            string responseMsg = string.Empty;
            UserDetails oldUser = _context.UserDetailData.FirstOrDefault(x => x.UserId == userInfo.UserId);

            if (oldUser != null)
            {
                responseMsg = "User Already Exist";
            }
            else
            {
                try
                {
                    _context.UserDetailData.Add(userInfo);
                    _context.SaveChanges();

                    if (userInfo.UserId != null)
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
