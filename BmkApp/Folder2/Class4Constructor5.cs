using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    internal class Class4Constructor5
    {
        public class Singleton
        {
            // Declare a private static field for the single instance
            private static Singleton instance;

            // Declare a public static property to get the single instance
            public static Singleton Instance
            {
                get
                {
                    return instance;
                }
            }

            // Define a private constructor to prevent instantiation from outside
            private Singleton()
            {
                Console.WriteLine("Private constructor called.");
            }

            // Define a static constructor to create the single instance
            static Singleton()
            {
                instance = new Singleton();
                Console.WriteLine("Static constructor called.");
            }

            // Define a method to display some message
            public void Display()
            {
                Console.WriteLine("Hello from Singleton.");
            }
        }

        // Define a class named Program
      
            // Define the main method
            static void Main(string[] args)
            {
                // Try to get the single instance of Singleton class using the property
                Singleton s1 = Singleton.Instance;
                Singleton s2 = Singleton.Instance;

                // Call the Display method on both instances
                s1.Display();
                s2.Display();

                // Check if both instances are the same object using reference equality
                Console.WriteLine("s1 and s2 are the same object: {0}", Object.ReferenceEquals(s1, s2));

            }
        

    }
}
