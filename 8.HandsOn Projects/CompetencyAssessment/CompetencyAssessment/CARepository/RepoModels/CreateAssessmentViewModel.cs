using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.RepoModels
{
    public class CreateAssessmentViewModel
    {
        public string AssmtName { get; set; }

        public string Description { get; set; }

        public DateTime AssmtDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
