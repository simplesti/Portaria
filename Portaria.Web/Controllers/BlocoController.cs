using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Data;

namespace Portaria.Web
{
    public class BlocoController : Controller
    {
        private PortariaContext db = new PortariaContext();

        // GET: Blocoes
        public ActionResult Index()
        {
            return View(db.Blocos.ToList());
        }

        // GET: Blocoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bloco bloco = db.Blocos.Find(id);
            if (bloco == null)
            {
                return HttpNotFound();
            }
            return View(bloco);
        }

        // GET: Blocoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blocoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] Bloco bloco)
        {
            if (ModelState.IsValid)
            {
                db.Blocos.Add(bloco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloco);
        }

        // GET: Blocoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bloco bloco = db.Blocos.Find(id);
            if (bloco == null)
            {
                return HttpNotFound();
            }
            return View(bloco);
        }

        // POST: Blocoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] Bloco bloco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloco);
        }

        // GET: Blocoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bloco bloco = db.Blocos.Find(id);
            if (bloco == null)
            {
                return HttpNotFound();
            }
            return View(bloco);
        }

        // POST: Blocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bloco bloco = db.Blocos.Find(id);
            db.Blocos.Remove(bloco);
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
