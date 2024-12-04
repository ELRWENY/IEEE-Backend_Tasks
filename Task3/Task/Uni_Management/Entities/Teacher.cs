using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department? department { get; set; }

        public List<Courses>? courses { get; set; }

    }
}
