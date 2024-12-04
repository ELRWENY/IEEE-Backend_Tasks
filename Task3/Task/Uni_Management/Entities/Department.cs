using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public String? Name { get; set; }

        public List<Teacher>? Teachers { get; set; }
    }
}
