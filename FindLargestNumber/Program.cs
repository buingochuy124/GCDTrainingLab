using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1:  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2:  ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number 3:  ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine($"Largest number is {max}");
            Console.ReadKey();
        }
    }
}
