using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    internal class Class4Constructor1
    {
        public class Student
        {
            // Declare some fields
            private string name;
            private int age;
            private double grade;

            // Define a default constructor
            public Student()
            {
                // Initialize the fields with default values
                name = "Unknown";
                age = 0;
                grade = 0.0;
            }

            // Define a method to display the student information
            public void Display()
            {
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Grade: {0}", grade);
            }
        }

        // Define a class named Program
        
            // Define the main method
            static void Main(string[] args)
            {
                // Create an object of Student class using the default constructor
                Student s1 = new Student();

                // Call the Display method on the object
                s1.Display();
            }
        
    }
}
