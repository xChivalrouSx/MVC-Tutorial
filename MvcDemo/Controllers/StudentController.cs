using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class StudentController : Controller
    {
        MvcDemoDb _db = new MvcDemoDb();

        // GET: Student
        public ActionResult Index()
        {
            var studentModel = _db.Students.ToList();

            return View(studentModel);
        }

        public ActionResult Edit(int id)
        {
            var studentModel = _db.Students.Find(id);

            return View(studentModel);
        }

        [HttpPost]
        public ActionResult Edit(Student studentModel)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(studentModel).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(studentModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}