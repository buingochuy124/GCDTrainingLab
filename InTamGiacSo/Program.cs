using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTamGiacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j+1);
                }
                Console.WriteLine();
            }

            for (int i  = N-2; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j+1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
