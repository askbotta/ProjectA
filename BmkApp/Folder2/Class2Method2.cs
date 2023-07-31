using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    internal class Class2Method2
    {

        

        // User defined function  
        public void Test1WithPerameters(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value  
        }

        public  void Test2(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        public void Test3(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
           
            int val = 50;
            Class2Method2 program = new Class2Method2(); // Creating Object  
            program.Test2("Liam");
            program.Test2("Jenny");
            program.Test2("Anja");
            program.Test3("Liam", 5);
            program.Test3("Jenny", 8);
            program.Test3("Anja", 31);


            Console.WriteLine("Value before passing out variable " + val);
            program.Test1WithPerameters(out val); // Passing out argument  
            Console.WriteLine("Value after recieving the out variable " + val);
        }
    }

}

