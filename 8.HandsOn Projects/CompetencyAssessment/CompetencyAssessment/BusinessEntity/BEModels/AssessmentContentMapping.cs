using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.BEModels
{
    public class AssessmentContentMapping
    {
        [Key]
        public int AssmtCaseStudyId { get; set; }
        [Required]
        public int AssmtId { get; set; }
        [Required]
        public int CaseStudyId { get; set; }
        [Required]
        public Boolean? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
