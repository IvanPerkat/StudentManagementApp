using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public class Student
    {
        private string? name;
        private string? surname;

        public Student(string? name, string? surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string StudentDetails()
        {
            return $"{name} {surname}";
        }
    }
}
