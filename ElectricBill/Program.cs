using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBill
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerBill huy = new CustomerBill();
            CustomerBill tuan = new CustomerBill(1,"tuan",800);
            huy.GetBill();
            huy.GetSurcharge();
            huy.GetCustomerInfo();
            Console.WriteLine("================================");

            tuan.GetBill();
            tuan.GetSurcharge();
            tuan.GetCustomerInfo();
            Console.ReadLine();
        }
    }
}
