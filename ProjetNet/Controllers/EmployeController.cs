using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projet_ASP.Models;
using Projet_ASP.DAO;
using System.Globalization;

namespace Projet_ASP.Controllers
{
    public class EmployeController : Controller
    {
        private MainContext db = new MainContext();

        //
        // GET: /Employe/

        public ActionResult Index(string metierid, string employeid, string debut_metier, string fin_metier, string roleid)
        {
            var employes = from s in db.Employe
                           select s;
            if (!String.IsNullOrEmpty(metierid) && !String.IsNullOrEmpty(employeid))
            {
                Metier metier = db.Metier.Find(Int32.Parse(metierid));
                Employe_Metier em = new Employe_Metier();

                DateTime dt_debut = DateTime.ParseExact(debut_metier,
                        "yyyy-MM-dd", CultureInfo.InvariantCulture);

                DateTime dt_fin = DateTime.ParseExact(fin_metier,
                        "yyyy-MM-dd", CultureInfo.InvariantCulture);


                Employe employe = db.Employe.Find(Int32.Parse(employeid));
                if (employe != null && metier != null)
                {
                    em.Employe = employe;
                    em.Metier = metier;
                    em.DebutMetier = dt_debut;
                    em.FinMetier = dt_fin;
                    db.Employe_Metier.Add(em);
                    db.SaveChanges();
                }
            }
            if (!String.IsNullOrEmpty(roleid) && !String.IsNullOrEmpty(employeid))
            {
                ViewData["employeid"] = employeid;
                ViewData["roleid"] = roleid;
                Roles role = db.Roles.Find(Int32.Parse(roleid));
                Employe_Role er = new Employe_Role();


                Employe employe = db.Employe.Find(Int32.Parse(employeid));
                if (employe != null && role != null)
                {
                    er.Employe = employe;
                    er.Role = role;
                    db.Employe_Role.Add(er);
                    db.SaveChanges();
                }
            }
            return View(employes);
        }

        //
        // GET: /Employe/Details/5

        public ActionResult Details(int id = 0)
        {
            Employe employe = db.Employe.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            var vem = from e in db.Employe_Metier select e ;
            var em = vem.Where(m => m.EmployeRefId == employe.EmployeID);
            List<string[]> metiers = new List<string[]>();
            
            return View(employe);
        }

        //
        // GET: /Employe/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employe/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employe employe)
        {
            if (ModelState.IsValid)
            {
                employe.Matricule = employe.Prenom.Substring(0, 1) + employe.Nom.ToLower().Substring(0, Math.Min(employe.Nom.Length, 10));
                employe.Matricule = employe.Matricule.ToLower();
                employe.Nom = employe.Nom.ToUpper();
                db.Employe.Add(employe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employe);
        }

        //
        //GET: /Employe/Search
        public ActionResult Search(string searchString)
        {
            var now = DateTime.Now;
            Employe employe = db.Employe.FirstOrDefault(e => e.Matricule.Equals(searchString));
            var employer_metiers = employe.Metiers;
            if (employer_metiers.Count > 0)
            {
                foreach (Employe_Metier em in employer_metiers)
                {
                    if (em.DebutMetier < now && em.FinMetier > now)
                    {

                        return RedirectToAction("AddRole", new { emp = employe });
                    }
                }
            }
            var metiers = from m in db.Metier
                          select m;
            //var em = db.Employe_Metier.Where(m => m.EmployeRefId.Equals(employe.EmployeID));
            metiers = metiers.OrderBy(s => s.Categorie)
                .Where(m => m.debut < now)
                .Where(m => m.fin > now);
            ViewData["metiers"] = metiers;
            return View(employe);
        }

            public ActionResult AddRole(Employe emp) {
                var roles = from m in db.Roles
                            select m;
                ViewData["roles"] = roles;
                return View(emp);
            }

        //
        // GET: /Employe/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employe employe = db.Employe.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            return View(employe);
        }

        //
        // POST: /Employe/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employe employe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employe);
        }

        //
        // GET: /Employe/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employe employe = db.Employe.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            return View(employe);
        }

        //
        // POST: /Employe/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employe employe = db.Employe.Find(id);
            db.Employe.Remove(employe);
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