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
    public class UserDetails
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string FullName { get; set; }

        [Column(TypeName = "int")]
        public int RoleID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string RoleName { get; set; }
    }
}
