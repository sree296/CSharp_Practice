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

            int count = activeUsers.Count()+1;
            var newUsers = new List<AssessmentUserMapping>(count);
            
            try
            {
                for (int i=1; i< count; i++)
                    {
                    newUsers[i].AssmtId = scheduleAssmtVM.AssmtId;
                    newUsers[i].CreatedBy = scheduleAssmtVM.CreatedBy;
                    newUsers[i].CreatedDate = DateTime.Now;
                    newUsers[i].UserId = Convert.ToInt32(activeUsers[i].UserId);
                    newUsers[i].isActive = activeUsers[i].isActive;
                        _context.AssessmentUserMappingData.Add(newUsers[i]);
                }
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
