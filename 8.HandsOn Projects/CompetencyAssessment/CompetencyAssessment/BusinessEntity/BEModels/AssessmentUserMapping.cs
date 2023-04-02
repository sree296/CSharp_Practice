using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.BEModels
{
    public class AssessmentUserMapping
    {
        [Key]
        public int AssmtUserId { get; set; }
        [Required]
        public int AssmtId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int isActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
