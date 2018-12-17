using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WordLearnerMVC;

namespace WordLearnerMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly WordLearnerContext db = new WordLearnerContext();

        // GET: Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Language).Include(u => u.Language1);
            return View(users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.DefDestinationLanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName");
            ViewBag.DefSourceLanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Name,DefSourceLanguageID,DefDestinationLanguageID")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DefDestinationLanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", user.DefDestinationLanguageID);
            ViewBag.DefSourceLanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", user.DefSourceLanguageID);
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.DefDestinationLanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", user.DefDestinationLanguageID);
            ViewBag.DefSourceLanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", user.DefSourceLanguageID);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Name,DefSourceLanguageID,DefDestinationLanguageID")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DefDestinationLanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", user.DefDestinationLanguageID);
            ViewBag.DefSourceLanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", user.DefSourceLanguageID);
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
