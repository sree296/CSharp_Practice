using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.BEModels
{
    public class UserInfo
    {
        [Key]
        // [Column(TypeName = "int")]
        public int Id { get; set; }

        [Required]
        // [Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }

        [Required]
        // [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        // [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        // [Column(TypeName = "varchar(50)")]
        public string EmpID { get; set; }

        // [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        // [Column(TypeName = "int")]
        public int RoleID { get; set; }

        // [Column(TypeName = "varchar(50)")]
        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        // [Column(TypeName = "varchar(50)")]
        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Boolean isActive { get; set; }

        public DateTime? PasswordChangeDate { get; set; }

    }
}
