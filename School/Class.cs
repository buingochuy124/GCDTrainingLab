using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class
    {
        public List<Student> Students;

        public Class()
        {
            Students = new List<Student>();
        }
        public void AddStudentToClass(Student student)
        {
            Students.Add(student);
        }
        public void PrintInfoClass()
        {
            foreach (var item in Students)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Dest);

            }
        }
    }
}
