using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Greenwich's Club of Developers";
           

            string[] arr = new string[a.Length];

            int n = a.Length;
            string b = "";
            for (int i = 0; i < n; i++)
            {
                 b = a.Substring(n - 1);
                 
            }
            
            
            
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
