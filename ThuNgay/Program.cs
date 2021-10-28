using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuNgay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a:  ");
            int a = int.Parse(Console.ReadLine());

            while ( a < 2 || a > 8 )
            {
                Console.Write("nhap lai a:   ");
                a = int.Parse(Console.ReadLine());
            }
            switch (a)
            {
                case 2:
                    Console.WriteLine("monday");
                    break;
                case 3:
                    Console.WriteLine("tuesday");
                    break;
                
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
