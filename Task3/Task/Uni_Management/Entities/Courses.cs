using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management.Entities
{
    public class Courses
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Credits { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        public Teacher? teacher { get; set; }

        public List<Student>? courseStudents { get; set; }
    }
}
