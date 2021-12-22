using System;

namespace classroom
{
    class Program
    {
        class Print1to10
        {
        int a;
        public static void Main(string[] args)
        {
                //print();
                Print1to10 a = new Print1to10();
                a.print();
        }
        public void print ()
        {

            for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
        }

        }
    }
}
