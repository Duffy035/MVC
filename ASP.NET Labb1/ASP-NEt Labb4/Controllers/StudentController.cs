using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NEt_Labb4.Models;

namespace ASP_NEt_Labb4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            Student student = new Student()
            {
                StudentId = 1,
                Adress = "Lommavägen 5",
                Name = "Bert",
                LastName = "Jönsson",
                PersonNumber = "19850213-4323",
                Grades = new List<Grade>()
                {
                    new Grade() {CourseName = "English", Id = 1, FinalGrade = "C"}
                }
            };
            Session["Student"] = student;
            return View(student);
        }
    }
}