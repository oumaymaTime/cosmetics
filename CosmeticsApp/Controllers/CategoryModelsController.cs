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
    public class CategoryModelsController : Controller
    {
        private CosmeticsAppContext db = new CosmeticsAppContext();

        // GET: CategoryModels
        public ActionResult Index()
        {
            return View(db.CategoryModels.ToList());
        }

        // GET: CategoryModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryModel categoryModel = db.CategoryModels.Find(id);
            if (categoryModel == null)
            {
                return HttpNotFound();
            }
            return View(categoryModel);
        }

        // GET: CategoryModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryModels/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,synonyme")] CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                db.CategoryModels.Add(categoryModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryModel);
        }

        // GET: CategoryModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryModel categoryModel = db.CategoryModels.Find(id);
            if (categoryModel == null)
            {
                return HttpNotFound();
            }
            return View(categoryModel);
        }

        // POST: CategoryModels/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,synonyme")] CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoryModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryModel);
        }

        // GET: CategoryModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryModel categoryModel = db.CategoryModels.Find(id);
            if (categoryModel == null)
            {
                return HttpNotFound();
            }
            return View(categoryModel);
        }

        // POST: CategoryModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoryModel categoryModel = db.CategoryModels.Find(id);
            db.CategoryModels.Remove(categoryModel);
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
