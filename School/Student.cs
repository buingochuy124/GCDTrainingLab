using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        public int Id;
        public string Name;
        public string Dest;
        public Student(int id, string name, string dest)
        {
            Id = id;
            Name = name;
            Dest = dest;
        }

        public void GetStudentInfo()
        {
            Console.WriteLine($"student id: {Id}");
            Console.WriteLine($"student name: {Name}");
            Console.WriteLine($"student dest: {Dest}");

        }



    }
}
