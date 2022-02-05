using System;
using System.Collections.Generic;

namespace TuesdayExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            int[] bulls_arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] bulls_arr2 = new int[] { 1, 2, 5, 7, 9 };
            int[] bulls_arr3 = new int[] { 1, 3, 4, 5, 8 };

            int[] sorted_data = SortStudentIDS(bulls_arr1, bulls_arr2, bulls_arr3);
            Console.WriteLine("Sorted array is:");
            foreach(int a in sorted_data)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            Console.WriteLine();



            //Questio 2
            string string1 = "egg";
            string string2 = "add";
            bool flag = IsIsomorphic(string1, string2);

            if (flag)
                Console.WriteLine("Given strigns are isomorphic");
            else
                Console.WriteLine("Given strigns are not isomorphic");

            Console.WriteLine();
            Console.WriteLine();


            //Question 3

            List<List<string>> paths = new List<List<string>>();
            paths.Add(new List<string>() {"MSC", "Library"});
            paths.Add(new List<string>() { "Library","HUB"});
            paths.Add(new List<string>() { "Library","HUB"});
            paths.Add(new List<string>() { "HUB","Muma College Of Business"});

            string destination = FinalDestination(paths);
            Console.WriteLine("Final Destination is {0}", destination);

            Console.WriteLine();
            Console.WriteLine();


            //Question 4
            int[] arr = new int[] { 0, 10, 5, 2 };
            int index = MountainPoint(arr);
            Console.WriteLine("Mountain point in the array is {0}", index);
            Console.WriteLine();
            Console.WriteLine();


            //Question 5

            string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            List<List<string>> groups = GroupAnagrams(words);
            foreach(List<string> group in groups)
            {
                foreach(string w in group)
                {
                    Console.Write(w + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

        }


        //Question 1


        public static int[] SortStudentIDS(int[] bulls_arr1, int[] bulls_arr2,int[] bulls_arr3)
        {
            int[] sorted_student_ids = new int[] {};
            try
            {
                

            }
            catch(Exception e)
            {
                throw;
            }
            return sorted_student_ids;
        }
//Question 2

       public static bool IsIsomorphic(string s1, string s2)
        {
        
            try
            {

            }
            catch(Exception e)
            {
                throw;

            }
            return false;
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
            return "sdfdsfldkfnldfnlsfnlsdnflkdflksd";
        }


//Question 4

    public static int MountainPoint(int[] arr)
        {

            try
            {

            }
            catch (Exception e)
            {
                throw;

            }
            return 0;

        }

//Question 5

    public static List<List<string>> GroupAnagrams(string[] strs)
        {
            List<List<string>> groupedStrings= new List<List<string>>();
            try
            {

            }
            catch (Exception e)
            {
                throw;

            }
            return groupedStrings;
        }


    }
}
