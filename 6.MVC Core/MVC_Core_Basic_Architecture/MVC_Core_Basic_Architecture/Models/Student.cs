namespace MVC_Core_Basic_Architecture.Models
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public decimal Marks { get; set; }

        public List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>
            {
                new Student { RollNumber = 1, Name = "AAA", Subject = "Physics", Marks = 100 },
                new Student { RollNumber = 2, Name = "BBB", Subject = "Physics", Marks = 90 },
                new Student { RollNumber = 3, Name = "CCC", Subject = "Physics", Marks = 80 },
                new Student { RollNumber = 4, Name = "DDD", Subject = "Physics", Marks = 80 },

            };


            return studentList;
        }

        public Student GetStudentOnRollNumber(int rollNumber)
        {
            Student studentDetail = new Student();

            List<Student> studentList = new List<Student>
            {
                new Student { RollNumber = 1, Name = "AAA", Subject = "Physics", Marks = 100 },
                new Student { RollNumber = 2, Name = "BBB", Subject = "Physics", Marks = 90 },
                new Student { RollNumber = 3, Name = "CCC", Subject = "Physics", Marks = 80 },
                new Student { RollNumber = 4, Name = "DDD", Subject = "Physics", Marks = 80 },

            };

            studentDetail = studentList.FirstOrDefault(x => x.RollNumber == rollNumber);

            return studentDetail;
        }

        public List<Student> DeleteStudentOnRollNumber(int rollNumber)
        {

            Student studentDeleted = new Student();

            List<Student> studentList = new List<Student>
            {
                new Student { RollNumber = 1, Name = "AAA", Subject = "Physics", Marks = 100 },
                new Student { RollNumber = 2, Name = "BBB", Subject = "Physics", Marks = 90 },
                new Student { RollNumber = 3, Name = "CCC", Subject = "Physics", Marks = 80 },
                new Student { RollNumber = 4, Name = "DDD", Subject = "Physics", Marks = 80 },

            };

            studentDeleted = studentList.FirstOrDefault(x => x.RollNumber == rollNumber);
            studentList.Remove(studentDeleted);

            return studentList;
        }
    }
}
