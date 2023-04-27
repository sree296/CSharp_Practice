using BusinessEntity.BEModels;
using CARepository.RepoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARepository.Abstract
{
    public interface IContentDetailsRepo
    {
        List<AssessmentDetail> GetAssessmentDetail();
        List<CompetencyDetail> GetCompetencyDetail();
        List<CaseStudyDetail> GetAllCaseStudies();

        CaseStudyDetail CreateCaseStudy(CreateCaseStudyViewModel createcaseStudy);
    }
}
