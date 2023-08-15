using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    //Perametarised constructor
    internal class Class4Constructor2
    {
        public class Person
        {
            // Declare some fields
            private string name;
            private int age;

            // Define a parameterized constructor
            public Person(string name, int age)
            {
                // Initialize the fields with the arguments
                this.name = name;
                this.age = age;
            }

            // Define a method to display the person information
            public void Display()
            {
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Age: {0}", age);
            }
        }

        // Define a class named Program
        
            // Define the main method
            static void Main(string[] args)
            {
                // Create an object of Person class using the parameterized constructor
                Person p1 = new Person("Alice", 25);

                // Call the Display method on the object
                p1.Display();
            }
        



    }
}
