using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string name, int age, string teacherid, string subject) : base(name, age)
        {
            TeacherId = teacherid;
            Subject = subject;
        }
    }
}
