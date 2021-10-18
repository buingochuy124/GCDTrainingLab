using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        
        static int GetSum(int a , int b)
        {
            int sum = a + b;
            return sum;
        }
       
        static int GetTru(int a , int b)
        {
            int Tru = 0;
            if (a >= b)
            {
                 Tru = a - b;
            }
            else
            {
                 Tru = b - a;

            }
            return Tru;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(1, 5));
            Console.WriteLine(GetTru(1, 5));

            Console.ReadLine();

        }
    }
}
