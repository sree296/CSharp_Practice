using BusinessEntity.BEModels;
using CARepository.Abstract;
using CARepository.Implementation;
using CARepository.RepoModels;
using Microsoft.AspNetCore.Mvc;

namespace CompetencyAssessment.Controllers
{
    public class ContentDetailController : Controller
    {
        IContentDetailsRepo _obj = new ContentDetailsRepo();

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateCaseStudy()
        {
            List<AssessmentDetail> assessmentList = _obj.GetAssessmentDetail();

            List<CompetencyDetail> competencyList = _obj.GetCompetencyDetail();

            CreateCaseStudyViewModel caseStudyView = new CreateCaseStudyViewModel();


            caseStudyView.Assessments = assessmentList;
            caseStudyView.Competencies = competencyList;

            return View(caseStudyView);
        }

        [HttpPost]
        public IActionResult CreateCaseStudy(CreateCaseStudyViewModel caseStudyView)
        {
            if (ModelState.IsValid)
            {
                string createBy = HttpContext.Session.GetString("UserName");
                caseStudyView.CreatedBy = createBy;
                CaseStudyDetail casestudyObj = _obj.CreateCaseStudy(caseStudyView);
                if(casestudyObj != null)
                {
                    return RedirectToAction("Index", "Home");

                }
            }

            return View();
        }
    }
}
