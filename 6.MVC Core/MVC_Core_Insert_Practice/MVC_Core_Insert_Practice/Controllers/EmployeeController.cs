using Microsoft.AspNetCore.Mvc;
using MVC_Core_Insert_Practice.Models;

namespace MVC_Core_Insert_Practice.Controllers
{
    public class EmployeeController : Controller
    {
        Employee employee = new Employee();
        public IActionResult Index()
        {
            List<Employee> empList = employee.GetAllEmployees();
            return View(empList);
        }
    }
}
