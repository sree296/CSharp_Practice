using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statements
{
    internal class ConditionsExample
    {
        /// <summary>
        /// Simple IF - Display Pass, If Marks is more than 50.
        /// </summary>
        public void SimpleIf()
        {
            Console.WriteLine("Enter Marks");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 50)
            {
                Console.WriteLine("You are Passed");
            }
        }

        public void ShortList()
        {
            Console.WriteLine("Do Your Have Degree - true/false ?");
            bool degree = Convert.ToBoolean(Console.ReadLine());
            if (degree)
            {
                Console.WriteLine("Enter Your Experiecne");
                int exp = Convert.ToInt32(Console.ReadLine());

                if (exp >= 5)
                {
                    Console.WriteLine("You are Shorlisted for Interview");
                }
            }
        }
    }
}
