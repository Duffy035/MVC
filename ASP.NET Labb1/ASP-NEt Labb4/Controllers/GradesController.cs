using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NEt_Labb4.Models;

namespace ASP_NEt_Labb4.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _GradesForStudents(int id)
        {
            List<Grade> grades = ((Student)Session["Student"]).Grades;
            return PartialView(grades);
        }

        public PartialViewResult _Create(int id)
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Create(Grade model)
        {
            ((Student)Session["Student"]).Grades.Add(model);
            return RedirectToAction(actionName: "_GradesForStudents", routeValues: new { id = 9 });
        }
    }
}