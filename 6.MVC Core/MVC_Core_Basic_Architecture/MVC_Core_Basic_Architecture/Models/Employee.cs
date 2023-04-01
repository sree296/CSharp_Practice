namespace MVC_Core_Basic_Architecture.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public List<Employee> EmpList { get; set; }


        public List<Employee> GetAllEmployees()
        {
            EmpList = new List<Employee>
                {
                    new Employee() { EmpId =100, Name="AAA", Salary=35000 },
                    new Employee() { EmpId =101, Name="AAA", Salary=30000 },
                    new Employee() { EmpId =102, Name="AAA", Salary=25000 },
             };

            return EmpList;
        }

        public List<Employee> CreateEmployee(Employee empObj)
        {
            EmpList = new List<Employee>
                {
                    new Employee() { EmpId =100, Name="AAA", Salary=35000 },
                    new Employee() { EmpId =101, Name="AAA", Salary=30000 },
                    new Employee() { EmpId =102, Name="AAA", Salary=25000 },
             };

            string msg = "Saved Employee Data";

            try
            {
                EmpList.Add(empObj);
            }
            catch (Exception ex)
            {
                msg = "Failed Saving Data";
            }

            return EmpList;
        }

        public Employee GetEmployeeOnEmpId(int empId)
        {
            Employee employee = new Employee();

            EmpList = new List<Employee>
                {
                    new Employee() { EmpId =100, Name="AAA", Salary=35000 },
                    new Employee() { EmpId =101, Name="AAA", Salary=30000 },
                    new Employee() { EmpId =102, Name="AAA", Salary=25000 },
             };

            employee = EmpList.FirstOrDefault(x => x.EmpId == empId);

            return employee;
        }

    }
}
