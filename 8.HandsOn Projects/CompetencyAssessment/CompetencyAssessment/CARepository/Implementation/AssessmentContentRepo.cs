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
    public class AssessmentContentRepo : IAssessmentContentRepo
    {
        CompetencyContext _context = new CompetencyContext();

        public List<AssessmentContentMapping> CreateAssmtCaseStudy(AssesmentCaseStudyViewModel assesmentCaseStudyVM)
        {
            List<CaseStudyDetail> activeCaseStudies = assesmentCaseStudyVM.CaseStudyList.ToList().FindAll(x => x.IsActive);


            List<AssessmentContentMapping> newCaseStudyMappings = new List<AssessmentContentMapping>();

            try
            {
                foreach (CaseStudyDetail caseStudyInfo in activeCaseStudies)
                {
                    newCaseStudyMappings.Add(
                        new AssessmentContentMapping
                        {
                            AssmtId = assesmentCaseStudyVM.AssmtId,
                            CreatedBy = assesmentCaseStudyVM.CreatedBy,
                            CreatedDate = DateTime.Now,
                            CaseStudyId = caseStudyInfo.CSID,
                            IsActive = caseStudyInfo.IsActive
                        }
                    ); ;
                }
                _context.AssessmentContentMappingData.AddRange(newCaseStudyMappings);
                // _context.CaseStudyDetailData.AddRange(activeCaseStudies);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            return newCaseStudyMappings;
        }
    }
}
