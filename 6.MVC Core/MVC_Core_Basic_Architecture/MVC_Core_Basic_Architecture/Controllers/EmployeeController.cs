using Microsoft.AspNetCore.Mvc;
using MVC_Core_Basic_Architecture.Models;

namespace MVC_Core_Basic_Architecture.Controllers
{
    public class EmployeeController : Controller
    {
        Employee employee = new Employee();
        public IActionResult Index()
        {
            List<Employee> empList = employee.GetAllEmployees();
            return View(empList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee empObj)
        {
            List<Employee> empList = employee.CreateEmployee(empObj);
            return View();
        }

        [HttpGet]
        public IActionResult GetEmpDetails(string empId)
        {
            Employee emp = employee.GetEmployeeOnEmpId(Convert.ToInt32(empId));
            return View(emp);
        }

    }
}
