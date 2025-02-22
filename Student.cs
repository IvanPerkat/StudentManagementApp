using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public class Student
    {
        private string? _name { get; }
        private string? _surname { get; }
        private string? _index { get; }
        private string? _course { get; }
        private DateOnly _birthDate { get; } 
        private int _year { get; }

        public Student(string? name, string? surname, string? index, string? course, DateOnly birthDate, int year)
        {
            _name = name;
            _surname = surname;
            _index = index;
            _course = course;
            _birthDate = birthDate;
            _year = year;
        }

        public string StudentDetails()
        {
            return $" {_index} | {_year}. | {_name} {_surname} | {_birthDate.ToShortDateString()} | {_course}";
        }
    }
}
