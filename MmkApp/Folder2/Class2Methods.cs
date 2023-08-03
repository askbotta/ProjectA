using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmkApp.Folder2
{
    internal class Class2Methods
    {
        public void Test1()
        {
            int X = 8;
            for (int i= 1; i < 10; i++)
            {
                Console.WriteLine($"{X}*{i} ={X*i}");
            }
        }


        public void Test2()
        {
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
        }



        public void Test3()
        {
            int i = 111;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 100);
        }
         
        public void Test4()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i == 30)
                    break;

            }
            Console.WriteLine("End of the loop");
        }
        public void Test5()
        {
            for(int i=1;i <= 100; i++)
            {
                if (i == 7 || i == 77)
                    continue;
                Console.WriteLine(i);
            }
        }
    
        static void Main()
        {
            Class2Methods btm = new Class2Methods();
            btm.Test1();
            btm.Test2();
            btm.Test3();
            btm.Test4();
            btm.Test5();
            Console.ReadLine ();
        }
    }
}
