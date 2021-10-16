using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student huy = new Student(1,"huy","rat la vippro");
            huy.GetStudentInfo();
            Class gcd = new Class();
            gcd.AddStudentToClass(huy);
            Console.WriteLine("======================");
            gcd.PrintInfoClass();
            Console.ReadKey();
        }
    }
}
