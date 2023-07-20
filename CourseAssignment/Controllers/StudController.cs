using CourseAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseAssignment.Controllers
{
    public class StudController : Controller
    {
        // GET: Stud
        CompanyContext cc = new CompanyContext();
        public ActionResult ViewCourse()
        {
            return View(this.cc.Courses.ToList());
        }
        [HttpPost]
        public ActionResult EnrollInCourse(int courseId, int studentId)
        {
            var course = cc.Courses.Find(courseId);
            var student = cc.Students.Find(studentId);

            if (course != null && student != null && course.Capacity > 0)
            {
                course.Capacity--;
                cc.SaveChanges();
            }

            return RedirectToAction("ViewCourse");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
          var rec= this.cc.Courses.Find(id);
            return View(rec);
        }
    }
}