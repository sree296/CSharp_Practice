using BusinessEntity.BEModels;
using CARepository.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.Abstract
{
    public interface IUserDetailsRepo
    {
        public UserDetails SubmitUserLogin(LoginViewModel loginViewModel);

        public string CreateNewUser(UserDetails userInfo);
    }
}
