using BusinessEntity.BEModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.RepoModels
{
    public class ActivateAssessmentViewModel
    {
        public List<AssessmentDetail>? AssessmentsList { get; set; }
        public int AssmtId {get;set;}
        public Boolean isActive { get; set; }
    }
}
