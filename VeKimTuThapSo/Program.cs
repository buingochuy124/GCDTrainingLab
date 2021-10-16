using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeKimTuThapSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Enter how many collumn?   ");
            int N = int.Parse(Console.ReadLine());
            int M = N;
            for (int i = 1; i <= N; i++)
            {
                for (int k = M; k > 0; k--)
                {
                    Console.Write(" ");
                    
                }
                for (int j = 1; j <= i; j++)
                {
                    
                    Console.Write(a+1);
                    a++;
                    Console.Write(" ");
                    
                }
                M--;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
