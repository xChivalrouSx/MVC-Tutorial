using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }

        List<Student> studentList = new List<Student>{
                            new Student() { StudentId = 1, Name = "John", Age = 18 } ,
                            new Student() { StudentId = 2, Name = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, Name = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, Name = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, Name = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, Name = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, Name = "Rob" , Age = 19 }
                        };
    }
}