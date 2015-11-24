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
    public class Project_IDController : Controller
    {
        private Raquels_FinalEntities db = new Raquels_FinalEntities();

        // GET: Project_ID
        public ActionResult Index()
        {
            var project_IDs = db.Project_IDs.Include(p => p.ScreenshotsOfProject);
            return View(project_IDs.ToList());
        }

        // GET: Project_ID/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project_ID project_ID = db.Project_IDs.Find(id);
            if (project_ID == null)
            {
                return HttpNotFound();
            }
            return View(project_ID);
        }

        // GET: Project_ID/Create
        public ActionResult Create()
        {
            ViewBag.ScreenshotID = new SelectList(db.ScreenshotsOfProjects, "ScreenshotID", "ScreenshotsOfProject1");
            return View();
        }

        // POST: Project_ID/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,NameoFProject,DescriptionOfProject,LinktoGithub,ScreenshotID")] Project_ID project_ID)
        {
            if (ModelState.IsValid)
            {
                db.Project_IDs.Add(project_ID);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ScreenshotID = new SelectList(db.ScreenshotsOfProjects, "ScreenshotID", "ScreenshotsOfProject1", project_ID.ScreenshotID);
            return View(project_ID);
        }

        // GET: Project_ID/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project_ID project_ID = db.Project_IDs.Find(id);
            if (project_ID == null)
            {
                return HttpNotFound();
            }
            ViewBag.ScreenshotID = new SelectList(db.ScreenshotsOfProjects, "ScreenshotID", "ScreenshotsOfProject1", project_ID.ScreenshotID);
            return View(project_ID);
        }

        // POST: Project_ID/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,NameoFProject,DescriptionOfProject,LinktoGithub,ScreenshotID")] Project_ID project_ID)
        {
            if (ModelState.IsValid)
            {
                db.Entry(project_ID).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ScreenshotID = new SelectList(db.ScreenshotsOfProjects, "ScreenshotID", "ScreenshotsOfProject1", project_ID.ScreenshotID);
            return View(project_ID);
        }

        // GET: Project_ID/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project_ID project_ID = db.Project_IDs.Find(id);
            if (project_ID == null)
            {
                return HttpNotFound();
            }
            return View(project_ID);
        }

        // POST: Project_ID/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project_ID project_ID = db.Project_IDs.Find(id);
            db.Project_IDs.Remove(project_ID);
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
