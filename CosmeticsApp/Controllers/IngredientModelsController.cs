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
    public class IngredientModelsController : Controller
    {
        private CosmeticsAppContext db = new CosmeticsAppContext();

        // GET: IngredientModels
        public ActionResult Index()
        {
            return View(db.IngredientModels.ToList());
        }

        // GET: IngredientModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientModel ingredientModel = db.IngredientModels.Find(id);
            if (ingredientModel == null)
            {
                return HttpNotFound();
            }
            return View(ingredientModel);
        }

        // GET: IngredientModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientModels/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NameIng,DefIng,paraben,safety_rules")] IngredientModel ingredientModel)
        {
            if (ModelState.IsValid)
            {
                db.IngredientModels.Add(ingredientModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ingredientModel);
        }

        // GET: IngredientModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientModel ingredientModel = db.IngredientModels.Find(id);
            if (ingredientModel == null)
            {
                return HttpNotFound();
            }
            return View(ingredientModel);
        }

        // POST: IngredientModels/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NameIng,DefIng,paraben,safety_rules")] IngredientModel ingredientModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingredientModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingredientModel);
        }

        // GET: IngredientModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IngredientModel ingredientModel = db.IngredientModels.Find(id);
            if (ingredientModel == null)
            {
                return HttpNotFound();
            }
            return View(ingredientModel);
        }

        // POST: IngredientModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IngredientModel ingredientModel = db.IngredientModels.Find(id);
            db.IngredientModels.Remove(ingredientModel);
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
