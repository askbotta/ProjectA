using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    internal class Class5StaticExamples1
    {
        public class Student
        {
            // some non-static fields and methods
            public string Name { get; set; }
            public int Id { get; set; }

            // a static method to display some information
            public static void Display()
            {
                Console.WriteLine("There are {0} students in total.", StudentCount);
                Console.WriteLine("The average grade is {0}.", AverageGrade);
            }
        }
    }
}
