using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Operation
{
    class Student
    {
        String Name, Id, Department;
        float cgpa;

        public void ShowInfo()
        { Console.WriteLine("Name: {0}\nID: {1}\nDepartment: {2}\nCGPA: {3}", Name, Id, Department, cgpa); }

        public void Property(String para)
        {
            String i = para;
            if(i == Name)
            { Console.WriteLine(Name); }
            else if(i == Id)
            { Console.WriteLine(Id); }
            else
            { Console.WriteLine(Department); }
        }
        public void Property(float grade)
        { Console.WriteLine(cgpa); }
    }
}
