using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Föreläsning10___ValidationExercisee.Models;

namespace Föreläsning10___ValidationExercisee.Controllers
{
    public class CakesController : Controller
    {
        private FoodContext db = new FoodContext();

        // GET: Cakes
        public ActionResult Index()
        {
            return View(db.Cakes.ToList());
        }

        // GET: Cakes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cake cake = db.Cakes.Find(id);
            if (cake == null)
            {
                return HttpNotFound();
            }
            return View(cake);
        }

        // GET: Cakes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CakeID,Name,Summary,Ingredients,CookingTime,Instructions")] Cake cake)
        {
            if (ModelState.IsValid)
            {
                db.Cakes.Add(cake);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cake);
        }

        // GET: Cakes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cake cake = db.Cakes.Find(id);
            if (cake == null)
            {
                return HttpNotFound();
            }
            return View(cake);
        }

        // POST: Cakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CakeID,Name,Summary,Ingredients,CookingTime,Instructions")] Cake cake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cake).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cake);
        }

        // GET: Cakes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cake cake = db.Cakes.Find(id);
            if (cake == null)
            {
                return HttpNotFound();
            }
            return View(cake);
        }

        // POST: Cakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cake cake = db.Cakes.Find(id);
            db.Cakes.Remove(cake);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
