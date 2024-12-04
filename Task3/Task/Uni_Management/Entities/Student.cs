using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }

        public List<Courses>? StudentCourses { get; set; }
    }
}
