using System;

namespace Method
{
    class Program
    {
        static void Add(int c, int d)
        {
            int tong = c + d;
            Console.WriteLine("tong :     " + tong);
        }
        static int Tru(int a, int b)
        {
            int hieu = a - b;
            return hieu;
        }
        static void PrintMenu()
        {
            Console.WriteLine("1. Phepcong");
            Console.WriteLine("2. Pheptru");
            Console.WriteLine("3. Phepnhan");
            Console.WriteLine("4. Phepchia");
            Console.WriteLine("5. thoat chuong trinh");

            Console.WriteLine("================");





        }

        static void Main(string[] args)
        {
            int option = 0;

            while (option != 5)
            {

                PrintMenu();

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("nhap so a:    ");

                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("nhap so b:    ");

                        int b = int.Parse(Console.ReadLine());

                        Add(a, b);
                        break;

                    case 2:
                        //phep tru
                        break;
                    default:
                        break;
                }

            }


            Console.ReadLine();

        }
    }
}
