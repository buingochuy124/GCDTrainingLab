using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter canh 1:  ");
            int a = int.Parse(Console.ReadLine());
            while (a <= 0)
            {
                Console.WriteLine("canh 1 can not  < 0 .Enter canh 1 Again !!! ");
                Console.Write("Enter canh 1:  ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter canh 2:  ");
            int b = int.Parse(Console.ReadLine());
            while (b <= 0)
            {
                Console.WriteLine("canh 2 can not  < 0 .Enter canh 2 Again !!! ");
                Console.Write("Enter canh 2:  ");
                b = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter canh 3:  ");
            int c = int.Parse(Console.ReadLine());
            while (c <= 0)
            {
                Console.WriteLine("canh 3 can not  < 0 .Enter canh 3 Again !!! ");
                Console.Write("Enter canh 3:  ");
                c = int.Parse(Console.ReadLine());
            }

            int CanhHuyen = a;
            if (CanhHuyen < b) { CanhHuyen = b; }
            if (CanhHuyen < c) { CanhHuyen = c; }

            if ( a == b  && b == c)
            {
                Console.WriteLine("tam giac deu");
            }
            else if ( a == b || b == c || c == a)
            {
                Console.WriteLine("tam giac can");
            }
            else
            {
                if(CanhHuyen == a)
                {
                    if (a*a == b*b + c * c)
                    {
                        Console.WriteLine("tam giac vuong co canh huyen la canh thu 1");
                    }
                    else
                    {
                        Console.WriteLine("khong thuoc tam giac vuong can hay deu!!!");
                    }

                }
                else if(CanhHuyen == b)
                {
                    if (b*b==a*a+c*c)
                    {
                        Console.WriteLine("tam giac vuong co canh huyen la canh thu 1");
                    }
                    else
                    {
                        Console.WriteLine("khong thuoc tam giac vuong can hay deu!!!");
                    }
                }
                else if(CanhHuyen == c)
                {
                    if (c*c == a*a+b*b)
                    {
                        Console.WriteLine("tam giac vuong co canh huyen la canh thu 1");
                    }
                    else
                    {
                        Console.WriteLine("khong thuoc tam giac vuong can hay deu!!!");
                    }
                }
                
            }



            Console.ReadLine();

        }
    }
}
