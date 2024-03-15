using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAZ1403.Classess
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Mobila { get; set;}
        public double Stepuxa { get; set; }
        public Student() 
        {
            Id = 0;
            LastName = string.Empty;
            FirstName = string.Empty;
            Age = 0;
            Mobila = string.Empty;
            Stepuxa = 0;
        }

        public Student(string firstname, int id, string lastname, int age, string mobila, double stepuxa)
        {
            Id = id;
            LastName = lastname; FirstName=firstname;
            Age = age;
            Mobila = mobila;
            Stepuxa = stepuxa;
        }
    }
}
