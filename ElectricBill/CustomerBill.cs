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
        public float Unit;

        public CustomerBill(int id, string name, float unit)
        {
            Id = id;
            Name = name; 

        }

    }
}
