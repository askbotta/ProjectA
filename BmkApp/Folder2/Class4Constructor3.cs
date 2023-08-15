using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    //copy constructor
    internal class Class4Constructor3
    {
        public class Employee
        {
            // Declare some properties
            public string Name { get; set; }
            public int Id { get; set; }
            public double Salary { get; set; }

            // Define a copy constructor
            public Employee(Employee e)
            {
                // Copy the values from the argument
                Name = e.Name;
                Id = e.Id;
                Salary = e.Salary;
            }

            // Define an instance constructor
            public Employee(string name, int id, double salary)
            {
                // Initialize the properties with the arguments
                Name = name;
                Id = id;
                Salary = salary;
            }

            // Define a method to display the employee information
            public void Display()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Id: {0}", Id);
                Console.WriteLine("Salary: {0}", Salary);
            }
        }

        // Define a class named Program
        
            // Define the main method
            static void Main(string[] args)
            {
                // Create an object of Employee class using the instance constructor
                Employee e1 = new Employee("Alice", 101, 5000);

                // Create another object of Employee class using the copy constructor
                Employee e2 = new Employee(e1);

                // Change some properties of e1 and e2
                e1.Name = "Bob";
                e1.Salary = 6000;
                e2.Id = 102;

                // Call the Display method on both objects
                Console.WriteLine("Employee 1:");
                e1.Display();
                Console.WriteLine("Employee 2:");
                e2.Display();
           }
        
    }
}
