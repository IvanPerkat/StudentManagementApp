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
        private string? couse;

        public Student(string? name, string? surname, string? index, string? couse)
        {
            this.name = name;
            this.surname = surname;
            this.index = index;
            this.couse = couse;
        }

        public string StudentDetails()
        {
            return $" {index} | {name} {surname} | {couse}";
        }
    }
}
