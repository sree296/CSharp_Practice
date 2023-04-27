using BusinessEntity.BEModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.RepoModels
{
    public class AssesmentCaseStudyViewModel
    {
        public int AssmtId { get; set; }
        public List<AssessmentDetail>? AssessmentsList { get; set; }
        public List<CaseStudyDetail>? CaseStudyList { get; set; }

        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
