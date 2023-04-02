using BusinessEntity.BEModels;
using CARepository.Abstract;
using CARepository.Implementation;
using CARepository.RepoModels;
using Microsoft.AspNetCore.Mvc;

namespace CompetencyAssessment.Controllers
{
    public class AssessmentDetailController : Controller
    {
        IAssessmentDetailsRepo _obj = new AssessmentDetailsRepo();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateAssessmentViewModel createAssessment)
        {
            if (ModelState.IsValid)
            {
                string createBy = HttpContext.Session.GetString("UserName");
                createAssessment.CreatedBy = createBy;
                AssessmentDetail assmentObj = _obj.CreateAssessment (createAssessment);
                if (createAssessment != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult ActiveAssessment()
        {
            List<AssessmentDetail> assessmentList = _obj.GetAllAssessments();
            ActivateAssessmentViewModel activateAssmtVM = new ActivateAssessmentViewModel();
            activateAssmtVM.AssessmentsList = assessmentList;
            return View(activateAssmtVM);
        }

        [HttpPost]
        public IActionResult ActiveAssessment(ActivateAssessmentViewModel activateAssmtVM)
        {
            AssessmentDetail assmtObj = _obj.ActivateAssessment(activateAssmtVM);
            if (assmtObj.AssmtID != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}
