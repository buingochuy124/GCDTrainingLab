using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        
       
        static string ClassName(string a)
        {
            return a;
        }
        static int StudentId(int b)
        {
            return b;
        }
        static void PrintNameOfTruong()
        {
            Console.WriteLine("University of Greenwich");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ClassName("GCD CLASS"));
            Console.WriteLine(StudentId(10));
            PrintNameOfTruong();
            Console.ReadLine();
        }
    }
}
