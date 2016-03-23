using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projet_ASP.Models;
using Projet_ASP.DAO;

namespace Projet_ASP.Controllers
{
    public class MetierController : Controller
    {
        private MainContext db = new MainContext();

        //
        // GET: /Metier/

        public ActionResult Index()
        {
            return View(db.Metier.ToList());
        }

        //
        // GET: /Metier/Details/5

        public ActionResult Details(int id = 0)
        {
            Metier metier = db.Metier.Find(id);
            if (metier == null)
            {
                return HttpNotFound();
            }
            return View(metier);
        }

        //
        // GET: /Metier/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Metier/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Metier metier)
        {
            if (ModelState.IsValid)
            {
                db.Metier.Add(metier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metier);
        }

        //
        // GET: /Metier/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Metier metier = db.Metier.Find(id);
            if (metier == null)
            {
                return HttpNotFound();
            }
            return View(metier);
        }

        //
        // POST: /Metier/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Metier metier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metier);
        }

        //
        // GET: /Metier/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Metier metier = db.Metier.Find(id);
            if (metier == null)
            {
                return HttpNotFound();
            }
            return View(metier);
        }

        //
        // POST: /Metier/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Metier metier = db.Metier.Find(id);
            db.Metier.Remove(metier);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}