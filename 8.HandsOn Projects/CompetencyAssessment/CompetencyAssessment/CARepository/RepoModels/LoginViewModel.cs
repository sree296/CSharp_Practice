﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.RepoModels
{
    public class LoginViewModel
    {
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }
    }
}
