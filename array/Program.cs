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
            int[] array = new int[] { 100, 60, 70, 10 , 100};


            int a = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(a == array[i])
                {
                   // count = count + 1;
                    count++;
                }
            }
            Console.WriteLine($"so {a} duoc lap lai {count} lan");

            Console.Read();

            }
    }
}
