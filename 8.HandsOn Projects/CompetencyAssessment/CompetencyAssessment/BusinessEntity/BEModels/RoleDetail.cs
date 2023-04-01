using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.BEModels
{
    [Table("RoleDetails")]
    public class RoleDetail
    {
        [Key]
        // [Column(TypeName = "int")]
        public int RoleID { get; set; }

        [Required]
        // [Column(TypeName = "varchar(50)")]
        public string RoleName { get; set; }

        // [Column(TypeName = "varchar(200)")]
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
