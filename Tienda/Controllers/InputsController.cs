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
    public class InputsController : Controller
    {
        private OnlineStoreContext db = new OnlineStoreContext();

        // GET: Inputs
        public ActionResult Index()
        {
            var inputs = db.Inputs.Include(i => i.Provider);
            return View(inputs.ToList());
        }

        // GET: Inputs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Input input = db.Inputs.Find(id);
            if (input == null)
            {
                return HttpNotFound();
            }
            return View(input);
        }

        // GET: Inputs/Create
        public ActionResult Create()
        {
            ViewBag.ProviderId = new SelectList(db.Providers, "Id", "Name");
            return View();
        }

        // POST: Inputs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PriceIn,DateIn,AmountIn,ProviderId")] Input input)
        {
            if (ModelState.IsValid)
            {
                db.Inputs.Add(input);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProviderId = new SelectList(db.Providers, "Id", "Name", input.ProviderId);
            return View(input);
        }

        // GET: Inputs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Input input = db.Inputs.Find(id);
            if (input == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProviderId = new SelectList(db.Providers, "Id", "Name", input.ProviderId);
            return View(input);
        }

        // POST: Inputs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PriceIn,DateIn,AmountIn,ProviderId")] Input input)
        {
            if (ModelState.IsValid)
            {
                db.Entry(input).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProviderId = new SelectList(db.Providers, "Id", "Name", input.ProviderId);
            return View(input);
        }

        // GET: Inputs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Input input = db.Inputs.Find(id);
            if (input == null)
            {
                return HttpNotFound();
            }
            return View(input);
        }

        // POST: Inputs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Input input = db.Inputs.Find(id);
            db.Inputs.Remove(input);
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
