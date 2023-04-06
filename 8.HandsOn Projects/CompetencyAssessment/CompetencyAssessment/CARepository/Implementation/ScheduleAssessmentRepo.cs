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
            var newUsers = new List<AssessmentUserMapping>();
            AssessmentUserMapping assessmentUser_1 = new AssessmentUserMapping();
            AssessmentUserMapping assessmentUser_2 = new AssessmentUserMapping();
            try
            {
                /*
                 * for (int i=1; i< count; i++)
                    {
                    newUsers[i].AssmtId = scheduleAssmtVM.AssmtId;
                    newUsers[i].CreatedBy = scheduleAssmtVM.CreatedBy;
                    newUsers[i].CreatedDate = DateTime.Now;
                    newUsers[i].UserId = activeUsers[i].Id;
                    newUsers[i].isActive = activeUsers[i].isActive;
                        _context.AssessmentUserMappingData.Add(newUsers[i]);
                }
                */
                assessmentUser_1.AssmtId = scheduleAssmtVM.AssmtId;
                assessmentUser_1.CreatedBy = scheduleAssmtVM.CreatedBy;
                assessmentUser_1.CreatedDate = DateTime.Now;
                assessmentUser_1.UserId = activeUsers[0].Id;
                assessmentUser_1.isActive = activeUsers[0].isActive;
                _context.AssessmentUserMappingData.Add(assessmentUser_1);

                assessmentUser_2.AssmtId = scheduleAssmtVM.AssmtId;
                assessmentUser_2.CreatedBy = scheduleAssmtVM.CreatedBy;
                assessmentUser_2.CreatedDate = DateTime.Now;
                assessmentUser_2.UserId = activeUsers[1].Id;
                assessmentUser_2.isActive = activeUsers[1].isActive;
                _context.AssessmentUserMappingData.Add(assessmentUser_2);

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
