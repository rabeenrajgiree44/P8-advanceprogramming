using System;

namespace sectionl
{
    class Program
    {
        string[] cars = { "Volvo", "BMW", "audi" };
        static void Main(string[] args)
        {
            Program p = new Program();
            for (int i = 0; i < p.cars.Length; i++)
            {
                Console.WriteLine(p.cars[i]);
            }
        }
    }
}
