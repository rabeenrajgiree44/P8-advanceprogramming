//write a program to get input integer number from user less than 3 and print number in string
using System;

namespace Section_L
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            string a = Console.ReadLine();
           
            if(a=="1")
            {
                Console.WriteLine("One");
                Console.ReadLine();
            }
            else if (a== "2")

            {
                Console.WriteLine("Two");
                Console.ReadLine();
            }
        }
    }
}
