using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace BmkApp.Folder2
{
    internal class Class4Constructor4
    {
        // examples of Static constructor in c sharp
       /* A static constructor is a special type of constructor that is used to initialize any static data or perform any action that needs to be done only once for a class. It is called automatically by the common language runtime(CLR) before the first instance of the class is created or any static members are accessed.A static constructor has the following characteristics1234:

It does not have any access modifiers or parameters.
        It cannot be inherited or overloaded.
        It cannot be called directly by the user.
        It can only access static members of the class.
It runs before any instance constructors.
        Here are some examples of how to use a static constructor in C#:

To initialize a static field with a complex expression: */


// Define a class named Circle
         public class Circle
        {
            // Declare a static field for the value of PI
        public static readonly double PI;

            // Declare an instance field for the radius
        public double Radius { get; set; }

        // Define a static constructor to initialize PI
        static Circle()
        {
            // Use the Math class to calculate PI
            PI = 4 * Math.Atan(1);
            Console.WriteLine("Static constructor called.");
        }

        // Define an instance constructor to initialize Radius
        public Circle(double radius)
        {
            Radius = radius;
            Console.WriteLine("Instance constructor called.");
        }

        // Define a method to calculate the area of the circle
        public double Area()
        {
            return PI * Radius * Radius;
        }
    }

    // Define a class named Program
   
        // Define the main method
        static void Main(string[] args)
        {
            // Create two objects of Circle class using the instance constructor
            Circle c1 = new Circle(5);
            Circle c2 = new Circle(10);

            // Call the Area method on both objects
            Console.WriteLine("Area of circle 1: {0}", c1.Area());
            Console.WriteLine("Area of circle 2: {0}", c2.Area());
        }
    
    }
}
