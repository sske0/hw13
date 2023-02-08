using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PIN { get; set; }

        public Student(string name, string surname, int pin)
        {
            Name = name;
            Surname = surname;
            PIN = pin;
        }
    }
}
