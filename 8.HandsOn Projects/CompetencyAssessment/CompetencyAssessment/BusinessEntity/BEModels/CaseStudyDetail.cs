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
    [Table("CaseStudyDetails")]
    public class CaseStudyDetail
    {
        [Key]
        // [Column(TypeName = "int")]
        public int CSID { get; set; }

        [Required]
        // [Column(TypeName = "varchar(200)")]
        public string CaseStudyName { get; set; }

        public int AssessmentID  { get; set; }

        public Boolean ReviewStatus { get; set; }

        public string? CareatedBy { get; set; }

    }
}
