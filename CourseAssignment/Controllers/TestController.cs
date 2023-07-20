using CourseAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseAssignment.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        CompanyContext cc = new CompanyContext();
        public ActionResult Index()
        {
            return View(this.cc.Courses.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course rec)
        {
            if(ModelState.IsValid)
            {
                this.cc.Courses.Add(rec);
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var rec = this.cc.Courses.Find(id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Course rec)
        {
            if(ModelState.IsValid)
            {
                this.cc.Entry(rec).State = System.Data.Entity.EntityState.Modified;
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var rec= this.cc.Courses.Find(id);
            return View(rec);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult Deleterec(Int64 Id)
        {
            var rec = this.cc.Courses.Find(Id);
            this.cc.Courses.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}