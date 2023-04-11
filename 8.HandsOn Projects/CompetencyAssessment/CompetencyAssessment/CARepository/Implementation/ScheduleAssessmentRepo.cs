using BusinessEntity.BEModels;
using BusinessEntity.Context;
using CARepository.Abstract;
using CARepository.RepoModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.Implementation
{
    public class ScheduleAssessmentRepo : IScheduleAssessmentRepo
    {
        CompetencyContext _context = new CompetencyContext();
        public List<AssessmentUserMapping> CreateSchedule(ScheduleAssessmentViewModel scheduleAssmtVM)
        {
            List<UserInfo> activeUsers = scheduleAssmtVM.UsersList.ToList().FindAll(x => x.isActive);

            List<AssessmentUserMapping> newUsers = new List<AssessmentUserMapping>();

            try
            {
                 foreach (UserInfo userInfo in activeUsers)
                    {
                    newUsers.Add(
                        new AssessmentUserMapping
                        {
                            AssmtId = scheduleAssmtVM.AssmtId,
                            CreatedBy = scheduleAssmtVM.CreatedBy,
                            CreatedDate = DateTime.Now,
                            UserId = userInfo.Id,
                            isActive = userInfo.isActive
                        }
                    );
                }
                _context.AssessmentUserMappingData.AddRange(newUsers);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                    string str = ex.Message;
            }
            
            return newUsers;
        }
    }
}
