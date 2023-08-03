namespace MmkApp.Folder2
{
    internal class OutputParameters
    {
        public void Math1(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a * b;
        }
        public (int,int) Math2(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            return (c,d);
        }
        static void Main()
        {
            OutputParameters p = new OutputParameters();
            int sum1, product1;
            p.Math1(117,17,out sum1 ,out product1);
            Console.WriteLine("sum of given number's is:" + sum1);
            Console.WriteLine("product of given number's is: " + product1+"\n");


            p.Math1 (100,25,out int sum2,out int product2);
            Console.WriteLine("sum of given number's is:" + sum2);
            Console.WriteLine("product of given number's is: " + product2 + "\n");

            (int sum3, int product3) = p.Math2(217, 17);
            Console.WriteLine("sum of given number's is:" + sum3);
            Console.WriteLine("product of given number's is: " + product3 + "\n");

            var (sum4, product4) = p.Math2(187, 17);
            Console.WriteLine("sum of given number's is:" + sum4);
            Console.WriteLine("product of given number's is: " + product4 + "\n");



            Console.ReadLine ();

        }
    }
}
