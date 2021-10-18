using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangCuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(N + " x " + (i+1) + " = " + (N*(i+1)));
            }
            Console.ReadLine();
        }
    }
}
