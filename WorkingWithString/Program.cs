using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Univ&er#@sity.Of.Gr**eenwich@";
            string[] String = new string[50];
            int count = 0;
            int countE = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                String[i] = s.Substring(i, 1);
            }
            foreach (var item in String)
            {               
                count++;
                if(item == "e")
                {
                    countE++;
                }
                
            }
            for (int i = 0; i < String.Length; i++)
            {
                if(String[i] == "&")
                {
                    String[i] = "";
                    count1++;
                }
                if (String[i] == "#")
                {
                    String[i] = "";
                    count2++;


                }
                if (String[i] == "@")
                {
                    String[i] = "";
                    count3++;


                }
                if (String[i] == "*")
                {
                    String[i] = "";
                    count4++;


                }
                if (String[i] == ".")
                {
                    String[i] = " ";
                }
            }

            foreach (var item in String)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            Console.WriteLine("So lan lap lai cua e trong mang: " + countE);

            Console.WriteLine("So phan tu trong mang:  "  + count);

            Console.WriteLine($"ki tu # bi xoa di: {count2}  lan");
            Console.WriteLine($"ki tu @ bi xoa di: {count3}  lan");
            Console.WriteLine($"ki tu * bi xoa di: {count4}  lan");
            Console.WriteLine($"ki tu & bi xoa di: {count1}  lan");


            Console.ReadLine(); 
        }
    }
}
