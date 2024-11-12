using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    public class Student
    {

        public string? Name { get; set; }
        public decimal Score { get; set; }

        public Student() { }
        public Student(string name, decimal score)
        {
            Name = name;
            Score = score;
        }
    }
}
