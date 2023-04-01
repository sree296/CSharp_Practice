using LoginUsingWcfService.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LoginUsingWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserLoginService" in both code and config file together.
    [ServiceContract]
    public interface IUserLoginService
    {
        [OperationContract]
        UserInfo UserLoginSubmit(string userId, string password);
    }
}
