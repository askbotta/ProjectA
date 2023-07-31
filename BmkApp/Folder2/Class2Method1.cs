using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace BmkApp.Folder2
{
    internal class Class2Method1
    {
        //Method are 4 types
        //1-NonValue Returning(Sub-routine)-(with void) with parameters, Below are few sample
        //1-Value returning with prameters(Function)
        //2-Value returning without prameters(Function)
        //
        //4-NonValue Returning (Sub-routine)-(with void) with out parameters

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


        //1-NonValue Returning(Sub-routine)-(with void) with parameters, Below are few sample
        public void Test1()
        {
            int x = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x}*{i}={x * i}");
            }
        }

        public void Test2IfCondition()
        {
                int num = 11;
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }  
        }
        public void Test3Switch()
        {
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 10: Console.WriteLine("It is 10"); break;
                    case 20: Console.WriteLine("It is 20"); break;
                    case 30: Console.WriteLine("It is 30"); break;
                    default: Console.WriteLine("Not 10, 20 or 30"); break;
                }  
        }
        public void Test4While()
        {
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    i++;
                }
        }
        public void Test5DoWhile()
        {
                int i = 1;
                do
                {
                    Console.WriteLine(i);
                    i++;
                } while (i <= 10);
        }
        public void Test6NestedDoWhile()
        {
                int i = 1;
                do
                {
                    int j = 1;

                    do
                    {
                        Console.WriteLine(i + " " + j);
                        j++;
                    } while (j <= 3);
                    i++;
                } while (i <= 3);
            
        }
        public void Test7Break()
        {
                for (int i = 1; i <= 10; i++)
                {
                    if (i == 5)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }   
        }
        public void Test8BreakWithInnerLoop()
        {
            
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        if (i == 2 && j == 2)
                        {
                            break;
                        }
                        Console.WriteLine(i + " " + j);
                    }
                }
            
        }
        public void Test9Continue()
        {
           
                for (int i = 1; i <= 10; i++)
                {
                    if (i == 5)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            
        }
        public void Test10ContinueInnerLoop()
        {
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        if (i == 2 && j == 2)
                        {
                            continue;
                        }
                        Console.WriteLine(i + " " + j);
                    }
                }    
        }
        static void Main()
        {
            Class2Method1 abc = new Class2Method1();
            abc.Test10ContinueInnerLoop();
            abc.Test9Continue();
            abc.Test8BreakWithInnerLoop();
            abc.Test7Break();
            abc.Test6NestedDoWhile();
            abc.Test4While();
            abc.Test1();
            abc.Test2IfCondition();
            abc.Test3Switch();
            Console.ReadLine();
        }
    }
}
