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
        private string? index;

        public Student(string? name, string? surname, string? index)
        {
            this.name = name;
            this.surname = surname;
            this.index = index;
        }

        public string StudentDetails()
        {
            return $" {index} | {name} {surname}";
        }
    }
}
