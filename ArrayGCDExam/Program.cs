using System;

namespace ArrayGCDExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 4, 5, 2, 3, 4, 2, 1, 1, 6, 7, 7 };
            int[] le = new int[a.Length];
            int[] chan = new int[a.Length];

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1)
                {
                    count1++;
                }
                if (a[i] == 2)
                {
                    count2++;
                }
                if (a[i] == 3)
                {
                    count3++;
                }
                if (a[i] == 4)
                {
                    count4++;
                }
                if (a[i] == 5)
                {
                    count5++;
                }
                if (a[i] == 6)
                {
                    count6++;
                }
                if (a[i] == 7)
                {
                    count7++;
                }
                sum = sum + a[i];
            }
            Console.WriteLine("Sum:  " + sum);
            Console.WriteLine($"So 1 lap lai {count1} lan");
            Console.WriteLine($"So 2 lap lai {count2} lan");
            Console.WriteLine($"So 3 lap lai {count3} lan");
            Console.WriteLine($"So 4 lap lai {count4} lan");
            Console.WriteLine($"So 5 lap lai {count5} lan");
            Console.WriteLine($"So 6 lap lai {count6} lan");
            Console.WriteLine($"So 7 lap lai {count7} lan");

            int j = 0;
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    chan[j] = a[i];
                    j++;
                }
                else
                {
                    le[k] = a[i];
                    k++;
                }

            }

            Console.Write("Mang so chan:   ");
            foreach (var item in chan)
            {
                if (item == 0)
                {
                    break;
                }
                Console.Write(item);
                Console.Write(" ");

            }
            Console.WriteLine();
            Console.Write("Mang so le:   ");

            foreach (var item in le)
            {
                if (item == 0)
                {
                    break;
                }
                Console.Write(item);
                Console.Write(" ");

            }


            Console.ReadKey();
        }
    }
}
