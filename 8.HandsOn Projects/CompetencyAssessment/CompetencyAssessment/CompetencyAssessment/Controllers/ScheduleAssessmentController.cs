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
            Console.WriteLine(scheduleAssmtVM);

            return View(scheduleAssmtVM);
        }
    }
}
