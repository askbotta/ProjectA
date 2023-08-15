using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    public static class Class5StaticExamples
    {
         private static int _resultStorage = 0; // a static field to store the result
            public static string Type = "Arithmetic"; // a static property to get or set the type of calculator
            public static int Sum(int num1, int num2) // a static method to calculate the sum of two numbers
            {
                return num1 + num2;
            }
            public static void Store(int result) // a static method to store the result in the static field
            {
                _resultStorage = result;
            }
        
    }
}
