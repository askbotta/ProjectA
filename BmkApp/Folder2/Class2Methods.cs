using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    internal class Class2Methods
    {
        //Method are 4 types
        //1-Value returning with prameters(Function)
        //2-Value returning without prameters(Function)
        //3-NonValue Returning (Sub-routine)-(with void) with out parameters
        //4-NonValue Returning (Sub-routine)-(with void) with parameters
       
        //[<modifiers>]void/type<name>([<Parameter List>])
        //{
        // stmt's or Logic
        //}
        //Perameters will make method Dynamic
        //print is not returning value
        //public static string ReadLine-- ReadLine returns results as a string 
        // Method should be defined inside of a class i.e Encapsolation
        //UNTILL INITIALISATION IS DONE MEMORY ALLOCATION IS NOT POSSIBLE
        //A CLASS IS AN USER DEFINED DATA TYPE 
        //FIRST LINE OF METHOD IS CALLED SIGNATURE
        //STATIC -- PREFIX THE CLASS NAME AND CALL THE METHOD
        //Non STATIC -- CREATE AN INSTANCE AND CALL
        //consume the program class from another class
        //consume the methods by either creating instance or by inheritance
        //Console.WriteLine(p.test3());
        //unnamed instance
        //new classname().CallMethod(); better to use only once
        // logical programs
        //user defined types
        //pre defined types

        public void Test1()
        {
            int x = 5;
            
                for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"{x}*{i}={x * i}");
                
            }

        }
        static void Main()
        {
            Class2Methods abc = new Class2Methods();
    
            abc.Test1();
            Console.ReadLine();
        }


    }
}
