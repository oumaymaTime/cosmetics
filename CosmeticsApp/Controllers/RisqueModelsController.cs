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
    public class RisqueModelsController : Controller
    {
        private CosmeticsAppContext db = new CosmeticsAppContext();

        // GET: RisqueModels
        public ActionResult Index()
        {
            return View(db.RisqueModels.ToList());
        }

        // GET: RisqueModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RisqueModel risqueModel = db.RisqueModels.Find(id);
            if (risqueModel == null)
            {
                return HttpNotFound();
            }
            return View(risqueModel);
        }

        // GET: RisqueModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RisqueModels/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NomR")] RisqueModel risqueModel)
        {
            if (ModelState.IsValid)
            {
                db.RisqueModels.Add(risqueModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(risqueModel);
        }

        // GET: RisqueModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RisqueModel risqueModel = db.RisqueModels.Find(id);
            if (risqueModel == null)
            {
                return HttpNotFound();
            }
            return View(risqueModel);
        }

        // POST: RisqueModels/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NomR")] RisqueModel risqueModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(risqueModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(risqueModel);
        }

        // GET: RisqueModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RisqueModel risqueModel = db.RisqueModels.Find(id);
            if (risqueModel == null)
            {
                return HttpNotFound();
            }
            return View(risqueModel);
        }

        // POST: RisqueModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RisqueModel risqueModel = db.RisqueModels.Find(id);
            db.RisqueModels.Remove(risqueModel);
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
