using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LoginUsingWcfService.ServiceModel
{
    [DataContract]
    public class UserInfo
    {
        public int Id { get; set; }

        [DataMember]
        public string UserId { get; set; }

        public string Password { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string EmpID { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string SuccessMessage { get; set; }
    }
}