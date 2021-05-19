using System;
using System.Collections.Generic;

namespace Update_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>{
            { 1, "John" },
            { 2, "Mrk" },
            { 3, "Bill" }
         };
            Console.WriteLine($"Name of student having id 2: {students[2]}");
            students[2] = "Mark";
            Console.WriteLine($"Updated Name of student having id 2: {students[2]}");
            Console.ReadLine();
        }
    }
}
