﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Enrollment? enrollment { get; set; }
    }
}
