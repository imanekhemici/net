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
    public class EmployeRoleController : Controller
    {
        private MainContext db = new MainContext();

        //
        // GET: /EmployeRole/

        public ActionResult Index()
        {
            var employe_role = db.Employe_Role.Include(e => e.Employe).Include(e => e.Role);
            return View(employe_role.ToList());
        }

        //
        // GET: /EmployeRole/Details/5

        public ActionResult Details(int id = 0)
        {
            Employe_Role employe_role = db.Employe_Role.Find(id);
            if (employe_role == null)
            {
                return HttpNotFound();
            }
            return View(employe_role);
        }

        //
        // GET: /EmployeRole/Create

        public ActionResult Create()
        {
            ViewBag.EmployeRefId = new SelectList(db.Employe, "EmployeID", "Nom");
            ViewBag.RoleRefId = new SelectList(db.Roles, "RoleId", "Titre");
            return View();
        }

        //
        // POST: /EmployeRole/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employe_Role employe_role)
        {
            if (ModelState.IsValid)
            {
                db.Employe_Role.Add(employe_role);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeRefId = new SelectList(db.Employe, "EmployeID", "Nom", employe_role.EmployeRefId);
            ViewBag.RoleRefId = new SelectList(db.Roles, "RoleId", "Titre", employe_role.RoleRefId);
            return View(employe_role);
        }

        //
        // GET: /EmployeRole/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employe_Role employe_role = db.Employe_Role.Find(id);
            if (employe_role == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeRefId = new SelectList(db.Employe, "EmployeID", "Nom", employe_role.EmployeRefId);
            ViewBag.RoleRefId = new SelectList(db.Roles, "RoleId", "Titre", employe_role.RoleRefId);
            return View(employe_role);
        }

        //
        // POST: /EmployeRole/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employe_Role employe_role)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employe_role).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeRefId = new SelectList(db.Employe, "EmployeID", "Nom", employe_role.EmployeRefId);
            ViewBag.RoleRefId = new SelectList(db.Roles, "RoleId", "Titre", employe_role.RoleRefId);
            return View(employe_role);
        }

        //
        // GET: /EmployeRole/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employe_Role employe_role = db.Employe_Role.Find(id);
            if (employe_role == null)
            {
                return HttpNotFound();
            }
            return View(employe_role);
        }

        //
        // POST: /EmployeRole/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employe_Role employe_role = db.Employe_Role.Find(id);
            db.Employe_Role.Remove(employe_role);
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