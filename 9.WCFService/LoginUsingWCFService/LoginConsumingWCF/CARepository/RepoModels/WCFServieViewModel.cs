﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.RepoModels
{
    public class WCFServieViewModel
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public string EmpID { get; set; }

        public string Email { get; set; }

        public string SuccessMessage { get; set; }
    }
}
