using BusinessEntity.BEModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.RepoModels
{
    public class RegisterViewModel
    {

        [Required]
        [DisplayName("User Id")]
        public string UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Employee Id")]
        public string EmpID { get; set; }

        [Required]
        public string Email { get; set; }

        [DisplayName("Role")]
        public int RoleID { get; set; }
        public List<RoleDetail>? RolesInfo { get; set; }

        [DisplayName("Is Active")]
        public Boolean isActive { get; set; }

        public string? CreatedBy { get; set; }

    }
}
