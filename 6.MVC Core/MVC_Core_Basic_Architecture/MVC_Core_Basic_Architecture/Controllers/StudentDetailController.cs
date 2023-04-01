using Microsoft.AspNetCore.Mvc;
using MVC_Core_Basic_Architecture.Models;


namespace MVC_Core_Basic_Architecture.Controllers
{
    public class StudentDetailController : Controller
    {
        Student student = new Student();
        public IActionResult Index()
        {
            List<Student> studentList  =  student.GetAllStudents();

            return View(studentList);
        }
        
        public IActionResult Details(string id)
        {
            Student studentItem = student.GetStudentOnRollNumber(Convert.ToInt32(id));
            return View(studentItem);
        }

        public IActionResult Delete(string id)
        {
            List<Student> studentList = student.DeleteStudentOnRollNumber(Convert.ToInt32(id));
            return View(studentList);
        }
    }
};
