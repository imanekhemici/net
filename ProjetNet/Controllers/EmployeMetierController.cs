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
    public class EmployeMetierController : Controller
    {
        private MainContext db = new MainContext();

        //
        // GET: /EmployeMetier/

        public ActionResult Index()
        {
            var employe_metier = db.Employe_Metier.Include(e => e.Employe).Include(e => e.Metier);
            return View(employe_metier.ToList());
        }

        //
        // GET: /EmployeMetier/Details/5

        public ActionResult Details(int id = 0)
        {
            Employe_Metier employe_metier = db.Employe_Metier.Find(id);
            if (employe_metier == null)
            {
                return HttpNotFound();
            }
            return View(employe_metier);
        }

        //
        // GET: /EmployeMetier/Create

        public ActionResult Create()
        {
            ViewBag.EmployeRefId = new SelectList(db.Employe, "EmployeID", "Nom");
            ViewBag.MetierRefId = new SelectList(db.Metier, "MetierId", "Categorie");
            return View();
        }

        //
        // POST: /EmployeMetier/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employe_Metier employe_metier)
        {
            if (ModelState.IsValid)
            {
                db.Employe_Metier.Add(employe_metier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeRefId = new SelectList(db.Employe, "EmployeID", "Nom", employe_metier.EmployeRefId);
            ViewBag.MetierRefId = new SelectList(db.Metier, "MetierId", "Categorie", employe_metier.MetierRefId);
            return View(employe_metier);
        }

        //
        // GET: /EmployeMetier/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employe_Metier employe_metier = db.Employe_Metier.Find(id);
            if (employe_metier == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeRefId = new SelectList(db.Employe, "EmployeID", "Nom", employe_metier.EmployeRefId);
            ViewBag.MetierRefId = new SelectList(db.Metier, "MetierId", "Categorie", employe_metier.MetierRefId);
            return View(employe_metier);
        }

        //
        // POST: /EmployeMetier/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employe_Metier employe_metier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employe_metier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeRefId = new SelectList(db.Employe, "EmployeID", "Nom", employe_metier.EmployeRefId);
            ViewBag.MetierRefId = new SelectList(db.Metier, "MetierId", "Categorie", employe_metier.MetierRefId);
            return View(employe_metier);
        }

        //
        // GET: /EmployeMetier/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employe_Metier employe_metier = db.Employe_Metier.Find(id);
            if (employe_metier == null)
            {
                return HttpNotFound();
            }
            return View(employe_metier);
        }

        //
        // POST: /EmployeMetier/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employe_Metier employe_metier = db.Employe_Metier.Find(id);
            db.Employe_Metier.Remove(employe_metier);
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