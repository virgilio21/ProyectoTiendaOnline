using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Tienda.Models
{
    public class OutputsController : Controller
    {
        private OnlineStoreContext db = new OnlineStoreContext();

        // GET: Outputs
        public ActionResult Index()
        {
            var outputs = db.Outputs.Include(o => o.Store);
            return View(outputs.ToList());
        }

        // GET: Outputs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Output output = db.Outputs.Find(id);
            if (output == null)
            {
                return HttpNotFound();
            }
            return View(output);
        }

        // GET: Outputs/Create
        public ActionResult Create()
        {
            ViewBag.StoreId = new SelectList(db.Stores, "Id", "Id");
            return View();
        }

        // POST: Outputs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PriceOut,DateOut,AmountOut,StoreId")] Output output)
        {
            if (ModelState.IsValid)
            {
                db.Outputs.Add(output);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StoreId = new SelectList(db.Stores, "Id", "Id", output.StoreId);
            return View(output);
        }

        // GET: Outputs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Output output = db.Outputs.Find(id);
            if (output == null)
            {
                return HttpNotFound();
            }
            ViewBag.StoreId = new SelectList(db.Stores, "Id", "Id", output.StoreId);
            return View(output);
        }

        // POST: Outputs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PriceOut,DateOut,AmountOut,StoreId")] Output output)
        {
            if (ModelState.IsValid)
            {
                db.Entry(output).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StoreId = new SelectList(db.Stores, "Id", "Id", output.StoreId);
            return View(output);
        }

        // GET: Outputs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Output output = db.Outputs.Find(id);
            if (output == null)
            {
                return HttpNotFound();
            }
            return View(output);
        }

        // POST: Outputs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Output output = db.Outputs.Find(id);
            db.Outputs.Remove(output);
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
