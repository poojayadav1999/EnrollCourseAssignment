using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseAssignment.Models
{
    public class Course
    {
       
        public Int64 CourseId { get; set; }
        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Desc Required")]
        public string Desc{ get; set; }
        [Required(ErrorMessage = "Name of Instructor Required")]
        public string NameofInstructor { get; set; }
        [Range(5,30,ErrorMessage ="Capacity should be 30")]
        public int Capacity { get; set; }
    }
}