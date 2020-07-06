using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FarmaciesController : Controller
    {
        private MySqlCon db = new MySqlCon();

        // GET: Farmacies
        public ActionResult Index()
        {
            return View(db.Farmacies.ToList());
        }

        // GET: Farmacies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmacies farmacies = db.Farmacies.Find(id);
            if (farmacies == null)
            {
                return HttpNotFound();
            }
            return View(farmacies);
        }

        // GET: Farmacies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Farmacies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Farmacies farmacies)
        {
            if (ModelState.IsValid)
            {
                db.Farmacies.Add(farmacies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(farmacies);
        }

        // GET: Farmacies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmacies farmacies = db.Farmacies.Find(id);
            if (farmacies == null)
            {
                return HttpNotFound();
            }
            return View(farmacies);
        }

        // POST: Farmacies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Farmacies farmacies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmacies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(farmacies);
        }

        // GET: Farmacies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farmacies farmacies = db.Farmacies.Find(id);
            if (farmacies == null)
            {
                return HttpNotFound();
            }
            return View(farmacies);
        }

        // POST: Farmacies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Farmacies farmacies = db.Farmacies.Find(id);
            db.Farmacies.Remove(farmacies);
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
