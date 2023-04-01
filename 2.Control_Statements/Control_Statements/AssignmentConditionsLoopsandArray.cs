using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statements
{
    public class AssignmentConditionsLoopsandArray
    {
        /**
         * Accept the year from user and say whether it is a leap year. 
         * (Check all 3 condition  :       
         *      2013 Not,
         *      2016 Leap, 
         *      2100 Not,
         *      2400 Leap) 
         */

        public void AssignmentOne()
        {
            Console.WriteLine("Enter a Year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year == 2013 || year == 2100)
            {
                Console.WriteLine("Not a Leap Year");
            }
            else if (year == 2016 || year == 2400)
            {
                Console.WriteLine("It is a Leap Year");
            }
        }

        /**
         * Accept an alphabet and say whether it’s vowel or not   (using SWITCH..CASE).
         */
        public void AssignmentTwo()
        {
            Console.WriteLine("Enter Alphabit");
            string Alphabit = Convert.ToString(Console.ReadLine()).ToLower();

            switch(Alphabit)
            {
                case "a":
                    Console.WriteLine("It is a Vowel");
                    break;
                case "e":
                    Console.WriteLine("It is a Vowel");
                    break;
                case "i":
                    Console.WriteLine("It is a Vowel");
                    break;  
                case "o":
                    Console.WriteLine("It is a Vowel");
                    break;      
                case "u":
                    Console.WriteLine("It is a Vowel");
                    break;

                default:
                    Console.WriteLine("Not a Vowel");
                    break;
            }
        }

        /**
         * 
         */

    }
}
