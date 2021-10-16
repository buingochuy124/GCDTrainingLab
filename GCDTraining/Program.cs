using System;

namespace GCDTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 4;
            string s = "";
            for (int i = 0; i < N; i++)
            {
                 s = s + (i+1).ToString();
                 Console.WriteLine(s);
            }
            
            Console.ReadLine();
        }
    }
}
