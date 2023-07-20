using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourseAssignment.Models
{
    public class CompanyContext:DbContext
    {
       public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}