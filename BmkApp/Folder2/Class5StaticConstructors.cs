using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    internal class Class5StaticConstructors
    {
        
            // a static field for the value of PI
            public static readonly double PI;

            // a non-static field for the radius
            public double Radius { get; set; }

            // a static constructor to initialize PI
            static Class5StaticConstructors()
            {
                // use the Math class to calculate PI
                PI = 4 * Math.Atan(1);
                Console.WriteLine("Static constructor called.");
            }

            // a non-static constructor to initialize Radius
            public Class5StaticConstructors(double radius)
            {
                Radius = radius;
                Console.WriteLine("Instance constructor called.");
            }

            // a non-static method to calculate the area of the circle
            public double Area()
            {
                return PI * Radius * Radius;
            }
        
    }
}
