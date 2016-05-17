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
    public class CakeReviewsController : Controller
    {
        private FoodContext db = new FoodContext();

        // GET: CakeReviews
        public ActionResult Index()
        {
            var reviews = db.Reviews.Include(c => c.Cake);
            return View(reviews.ToList());
        }

        // GET: CakeReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CakeReview cakeReview = db.Reviews.Find(id);
            if (cakeReview == null)
            {
                return HttpNotFound();
            }
            return View(cakeReview);
        }

        // GET: CakeReviews/Create
        public ActionResult Create()
        {
            ViewBag.CakeList = new SelectList(db.Cakes, "CakeID", "Name");
            return View();
        }

        // POST: CakeReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CakeReviewID,Title,Summary,Score,CakeID")] CakeReview cakeReview)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(cakeReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CakeID = new SelectList(db.Cakes, "CakeID", "Name", cakeReview.CakeID);
            return View(cakeReview);
        }

        // GET: CakeReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CakeReview cakeReview = db.Reviews.Find(id);
            if (cakeReview == null)
            {
                return HttpNotFound();
            }
            ViewBag.CakeID = new SelectList(db.Cakes, "CakeID", "Name", cakeReview.CakeID);
            return View(cakeReview);
        }

        // POST: CakeReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CakeReviewID,Title,Summary,Score,CakeID")] CakeReview cakeReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cakeReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CakeID = new SelectList(db.Cakes, "CakeID", "Name", cakeReview.CakeID);
            return View(cakeReview);
        }

        // GET: CakeReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CakeReview cakeReview = db.Reviews.Find(id);
            if (cakeReview == null)
            {
                return HttpNotFound();
            }
            return View(cakeReview);
        }

        // POST: CakeReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CakeReview cakeReview = db.Reviews.Find(id);
            db.Reviews.Remove(cakeReview);
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
