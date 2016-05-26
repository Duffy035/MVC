using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxTentaTest.Models;

namespace AjaxTentaTest.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _Create(int id)
        {
            Car car = new Car() {PersonId = id};
            return PartialView(viewName: "_Create", model: car);
        }

        [HttpGet]
        public void _HideCreate() { }

        [HttpGet]
        public PartialViewResult _Create2(int id)
        {
            Car car = new Car() {PersonId = id};
            return PartialView(viewName: "_Create2", model: car);
        }

        public string _Create2(int id, Car model)
        {
            return "Car created!";
        }
    }
}