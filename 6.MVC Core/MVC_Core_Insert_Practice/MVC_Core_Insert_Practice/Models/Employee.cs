namespace MVC_Core_Insert_Practice.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public List<Employee> EmpList { get; set; }

        public Employee()
        {
            EmpList = new List<Employee>
                {
                    new Employee() { EmpId =100, Name="AAA", Salary=35000 },
                    new Employee() { EmpId =101, Name="AAA", Salary=30000 },
                    new Employee() { EmpId =102, Name="AAA", Salary=25000 },
                };
        }

        public List<Employee> GetAllEmployees()
        {
            return EmpList;
        }

        public string InsertEmployee(Employee empObj)
        {
            string msg = "Saved Employee Data";

            try
            {
                EmpList.Add(empObj);
            }
            catch(Exception ex)
            {
                msg = "Failed Saving Data";
            }

            return msg;
        }

    }
}
