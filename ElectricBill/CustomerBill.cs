using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBill
{

    class CustomerBill
    {
        public int Id;
        public string Name;
        public double Unit;
        public double Bill; 
        public double Surcharge;

        public CustomerBill()
        {
            Id = 0;
            Name = "N/A";
            Unit = 0;
        }
        public CustomerBill(int id, string name, float unit)
        {
            Id = id;
            Name = name;
            Unit = unit;
        }

        public void GetBill()
        {
            if(Unit <= 199)
            {
                Bill = Unit * 1.2;
            }
            else if (Unit < 400)
            {
                Bill = Unit * 1.5;
            }
            else if (Unit < 600)
            {
                Bill = Unit * 1.8;
            }
            else if (Unit >= 600)
            {
                Bill = Unit * 2;
            }

        }
        public double GetSurcharge()
        {
            if(Bill > 400)
            {
                Surcharge = Bill / 100 * 15;
            }
            return Surcharge;
        }
        public void GetCustomerInfo()
        {
            Console.WriteLine($"Customer Name : {Name}");
            Console.WriteLine($"Customer Unit : {Unit}");
            Console.WriteLine($"Customer need pay {Bill} for bill !!!!");
            Console.WriteLine($"Surcharge Amount : {Surcharge}");
            Console.WriteLine($"Net Amount Paid By the Customer : {Surcharge+Bill}");
        }
    }
}
