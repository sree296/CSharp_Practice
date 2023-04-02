using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.RepoModels
{
    public class ScheduleAssessmentUserViewModel
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public Boolean isActiveUser { get; set; }

        public int? AssmtId { get; set; }
        public string? AssmtName { get; set; }
    }
}
