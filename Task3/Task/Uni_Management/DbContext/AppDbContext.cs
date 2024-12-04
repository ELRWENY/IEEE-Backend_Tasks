using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using University_Management.Entities;

namespace University_Management.DbContex
{
    public class Appdbcontext : DbContext
    {
        public DbSet<Student>? students { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<Courses>? Courses { get; set; }
        public DbSet<Enrollment>? Enrollments { get; set; }
        public DbSet<Grade>? Grades { get; set; }
        public DbSet<Department>? Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetSection("constr").Value);

        }
    }
}
