using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.BEModels
{
    [Table("AssessmentDetails")]
    public class AssessmentDetail
    {
        [Key]
        // [Column(TypeName = "int")]
        public int AssmtID { get; set; }

        [Required]
        // [Column(TypeName = "varchar(200)")]
        public string AssmtName { get; set; }

        [Required]
        // [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }

        [Required]
        public DateTime AssmtDate { get; set; }
        public bool isActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
