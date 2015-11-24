using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalCountdown.Models;

namespace FinalCountdown.Controllers
{
    public class ScreenshotsOfProjectsController : Controller
    {
        private Raquels_FinalEntities db = new Raquels_FinalEntities();

        // GET: ScreenshotsOfProjects
        public ActionResult Index()
        {
            return View(db.ScreenshotsOfProjects.ToList());
        }

        // GET: ScreenshotsOfProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScreenshotsOfProject screenshotsOfProject = db.ScreenshotsOfProjects.Find(id);
            if (screenshotsOfProject == null)
            {
                return HttpNotFound();
            }
            return View(screenshotsOfProject);
        }

        // GET: ScreenshotsOfProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScreenshotsOfProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ScreenshotID,ScreenshotsOfProject1")] ScreenshotsOfProject screenshotsOfProject)
        {
            if (ModelState.IsValid)
            {
                db.ScreenshotsOfProjects.Add(screenshotsOfProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(screenshotsOfProject);
        }

        // GET: ScreenshotsOfProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScreenshotsOfProject screenshotsOfProject = db.ScreenshotsOfProjects.Find(id);
            if (screenshotsOfProject == null)
            {
                return HttpNotFound();
            }
            return View(screenshotsOfProject);
        }

        // POST: ScreenshotsOfProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ScreenshotID,ScreenshotsOfProject1")] ScreenshotsOfProject screenshotsOfProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(screenshotsOfProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(screenshotsOfProject);
        }

        // GET: ScreenshotsOfProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScreenshotsOfProject screenshotsOfProject = db.ScreenshotsOfProjects.Find(id);
            if (screenshotsOfProject == null)
            {
                return HttpNotFound();
            }
            return View(screenshotsOfProject);
        }

        // POST: ScreenshotsOfProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScreenshotsOfProject screenshotsOfProject = db.ScreenshotsOfProjects.Find(id);
            db.ScreenshotsOfProjects.Remove(screenshotsOfProject);
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
