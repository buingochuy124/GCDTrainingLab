using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            while (year <= 0)
            {
                Console.Write("Enter year again: ");
                year = int.Parse(Console.ReadLine());
            }

            if (((year % 4) == 0 && !((year % 100) == 0)) || (year % 400 == 0))
            {
                Console.WriteLine($" {year} is leap year");
            }
            else
            {
                Console.WriteLine($"{year} not leap year");
            }
        }
    }
}
