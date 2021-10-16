using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateRootOfQuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a:   ");
            double a = double.Parse(Console.ReadLine());
            while(a == 0)
            {
                Console.Write("Enter a again:  ");
                a = double.Parse(Console.ReadLine());
            }
            Console.Write("Enter b:   ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c:   ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            double nghiemkep = -b/(2*a);
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem !!!");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Phuong trinh co nghiem kep x1 = x2 = {nghiemkep}  ");

            }
            else
            {
                Console.WriteLine($"Phuong trinh co 2 nghiem kep x1 =  {-b - Math.Sqrt(delta) / (2*a)  }   va x2 = {-b + Math.Sqrt(delta) / (2 * a) } ");
            }
            Console.ReadLine();
        }
    }
}
