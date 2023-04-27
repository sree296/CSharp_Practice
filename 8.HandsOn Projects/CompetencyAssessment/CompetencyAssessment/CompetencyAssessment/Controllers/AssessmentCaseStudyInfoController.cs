using BusinessEntity.BEModels;
using CARepository.Abstract;
using CARepository.Implementation;
using CARepository.RepoModels;
using Microsoft.AspNetCore.Mvc;

namespace CompetencyAssessment.Controllers
{
    public class AssessmentCaseStudyInfoController : Controller
    {
        IAssessmentDetailsRepo _assmtObj = new AssessmentDetailsRepo();
        IContentDetailsRepo _contentObj = new ContentDetailsRepo();
        IAssessmentContentRepo _assessmentContentObj = new AssessmentContentRepo();

        [HttpGet]
        public IActionResult Create()
        {
            AssesmentCaseStudyViewModel assesmentCaseStudyVM = new AssesmentCaseStudyViewModel();

            assesmentCaseStudyVM.AssessmentsList = _assmtObj.GetAllAssessments();
            assesmentCaseStudyVM.CaseStudyList = _contentObj.
                GetAllCaseStudies();

            return View(assesmentCaseStudyVM);
        }

        [HttpPost]
        public IActionResult Create(AssesmentCaseStudyViewModel assesmentCaseStudyVM)
        {
            string createBy = HttpContext.Session.GetString("UserName");

            assesmentCaseStudyVM.CreatedBy = createBy;

            List<AssessmentContentMapping> assmntCaseStudies = _assessmentContentObj.CreateAssmtCaseStudy(assesmentCaseStudyVM);

            if (assmntCaseStudies != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(assesmentCaseStudyVM);
        }
    }
}
