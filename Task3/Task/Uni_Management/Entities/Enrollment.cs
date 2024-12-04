using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Grade")]
        public int GradeId { get; set; }

        [ForeignKey("Courses")]
        public int CourseId { get; set; }

        public Grade? grade { get; set; }

    }
}
