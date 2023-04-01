using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CARepository.RepoModels
{
    public class ChangePasswordModel
    {
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("New Password")]
        public string NewPassword { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Retype New Password")]
        public string ConfirmNewPassword { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
