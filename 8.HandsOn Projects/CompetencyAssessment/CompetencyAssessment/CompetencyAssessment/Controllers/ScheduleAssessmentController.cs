using BusinessEntity.BEModels;
using CARepository.Abstract;
using CARepository.Implementation;
using CARepository.RepoModels;
using Microsoft.AspNetCore.Mvc;

namespace CompetencyAssessment.Controllers
{
    public class ScheduleAssessmentController : Controller
    {
        IAssessmentDetailsRepo _assmtObj = new AssessmentDetailsRepo();
        IUserDetailsRepo _usersObj = new UserDetailsRepo();
        IScheduleAssessmentRepo _schduleAssmntObj = new ScheduleAssessmentRepo();

        [HttpGet]
        public IActionResult Schedule()
        {
            ScheduleAssessmentViewModel scheduleAssmtVM = new ScheduleAssessmentViewModel();

            scheduleAssmtVM.AssessmentsList = _assmtObj.GetAllAssessments();
            scheduleAssmtVM.UsersList = _usersObj.GetAllUsers();

            return View(scheduleAssmtVM);
        }

        [HttpPost]
        public IActionResult Schedule(ScheduleAssessmentViewModel scheduleAssmtVM)
        {
            string createBy = HttpContext.Session.GetString("UserName");

            scheduleAssmtVM.CreatedBy = createBy;

            List<AssessmentUserMapping> assmntUser = _schduleAssmntObj.CreateSchedule(scheduleAssmtVM);

            if (assmntUser != null)
            {
                return RedirectToAction("Index", "Home");

            }

            return View(scheduleAssmtVM);
        }
    }
}
