using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statements
{
    public class ArrayAssignments
    {

        /// <summary>
        /// Accept an integer array of 6 elements and 
        /// then accept another number to check 
        /// whether the number exists in the array or not.
        /// </summary>
        public void AssignmentOne()
        {
            Console.WriteLine("Enter 6 Numbers");
            int[] arr = new int[6];

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Another Number to Check in the Array");
            int number = Convert.ToInt32(Console.ReadLine());

            foreach(int n in arr)
            {
                if (n == number)
                {
                    Console.WriteLine("Number Exist");
                }
            }
        }

        /**
         * Accept an integer array of 5 elements and sort it in ascending order.
         */
        public void AssignmentTwo()
        {
            Console.WriteLine("Enter 5 Numbers");
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int n=arr.Length-1; n>1; n--)
            {
                for(int i=0; i<n; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = t;
                    }
                }
            };

            foreach(int k in arr)
            {
                Console.WriteLine(k);
            }

        }

        /**
         * Accept a 3 X 3 Matrix and display TRANSPOSE Matrix.
         */
        public void AssignmentThree()
        {
            Console.WriteLine("Enter Values for 3 x 3 Matrix");
            int[,] arr = new int[3, 3];
            for(int rc=0; rc<3; rc++)
            {
                for(int cc=0; cc<3; cc++)
                {
                    arr[rc, cc] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int rc = 0; rc < 3; rc++)
            {
                for (int cc = 0; cc < 3; cc++)
                {
                    Console.Write(arr[rc, cc] + "\t");
                }
            }

            Console.ReadKey();
        }

    }
}
