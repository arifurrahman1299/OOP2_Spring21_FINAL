using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Arifur", "18-38852-3", 3.34f);
            Student s2 = new Student("Rahman", "18-38852-2", 3.3f);
            Department d1 = new Department("Computer Science", "CSE");
            s1.Department = d1;
            s2.Department = d1;
            d1.AddStudent(s1);
            d1.AddStudent(s2);
            d1.AllStudents();
        }
    }
}