using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CosmeticsApp.Models;

namespace CosmeticsApp.Controllers
{
    public class AllergiesController : Controller
    {
        private CosmeticsAppContext db = new CosmeticsAppContext();

        // GET: Allergies
        public ActionResult Index()
        {
            return View(db.Allergies.ToList());
        }

        // GET: Allergies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allergie allergie = db.Allergies.Find(id);
            if (allergie == null)
            {
                return HttpNotFound();
            }
            return View(allergie);
        }

        // GET: Allergies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Allergies/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NameAllergie,Warning")] Allergie allergie)
        {
            if (ModelState.IsValid)
            {
                db.Allergies.Add(allergie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(allergie);
        }

        // GET: Allergies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allergie allergie = db.Allergies.Find(id);
            if (allergie == null)
            {
                return HttpNotFound();
            }
            return View(allergie);
        }

        // POST: Allergies/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NameAllergie,Warning")] Allergie allergie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allergie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(allergie);
        }

        // GET: Allergies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allergie allergie = db.Allergies.Find(id);
            if (allergie == null)
            {
                return HttpNotFound();
            }
            return View(allergie);
        }

        // POST: Allergies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Allergie allergie = db.Allergies.Find(id);
            db.Allergies.Remove(allergie);
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
