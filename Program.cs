using System;
using System.Collections.Generic;

namespace TuesdayExam
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1

            int N = 6;
            PrintPattern(N);
            Console.WriteLine();
            Console.WriteLine();

            //Question 2

            int[] bulls_arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] bulls_arr2 = new int[] { 1, 2, 5, 7, 9 };
            int[] bulls_arr3 = new int[] { 1, 3, 4, 5, 8 };

            int[] sorted_data = SortStudentIDS(bulls_arr1, bulls_arr2, bulls_arr3);
            Console.WriteLine("Sorted array is:");
            foreach (int a in sorted_data)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //Question 3

            List<List<string>> paths = new List<List<string>>();
            paths.Add(new List<string>() { "MSC", "Library" });
            paths.Add(new List<string>() { "Library", "HUB" });
            paths.Add(new List<string>() { "HUB", "Muma College Of Business" });

            string destination = FinalDestination(paths);
            Console.WriteLine("Final Destination is {0}", destination);
            Console.WriteLine();
            Console.WriteLine();

        }


        //Question 1

        public static void PrintPattern(int N)
        {

            try
            {

            }
            catch (Exception e)
            {
                throw;

            }
        }




        //Question 2


        public static int[] SortStudentIDS(int[] bulls_arr1, int[] bulls_arr2, int[] bulls_arr3)
        {
            int[] sorted_student_ids = new int[] { };
            try
            {


            }
            catch (Exception e)
            {
                throw;
            }
            return sorted_student_ids;
        }

        //Question 3

        public static string FinalDestination(List<List<string>> paths)
        {

            try
            {

            }
            catch (Exception e)
            {
                throw;

            }
            return "";
        }


    }
}
