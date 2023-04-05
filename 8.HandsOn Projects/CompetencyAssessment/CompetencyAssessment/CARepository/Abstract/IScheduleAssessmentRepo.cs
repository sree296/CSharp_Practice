using BusinessEntity.BEModels;
using CARepository.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.Abstract
{
    public interface IScheduleAssessmentRepo
    {
        List<AssessmentUserMapping> CreateSchedule(ScheduleAssessmentViewModel scheduleAssmtVM);
    }
}
