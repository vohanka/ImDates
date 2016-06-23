using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ImDatesAsp.Entities;
using ImDatesAsp.Models;

namespace ImDatesAsp.Controllers
{
    public class RemindedPersonsController : Controller
    {
        private RemindingContext db = new RemindingContext();

        // GET: RemindedPersons
        public ActionResult Index()
        {
            return View(db.RemindedPersons.ToList());
        }

        // GET: RemindedPersons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RemindedPerson remindedPerson = db.RemindedPersons.Find(id);
            if (remindedPerson == null)
            {
                return HttpNotFound();
            }
            return View(remindedPerson);
        }

        // GET: RemindedPersons/Create
        public ActionResult Create()
        {
			var newPerson = new RemindedPerson { Notify = true };
            return View(newPerson);
        }

        // POST: RemindedPersons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,NameDayDate,BirthdayDate,RemindBeforeInDays,RemindAt,Description,Notify")] RemindedPerson remindedPerson)
        {
            if (ModelState.IsValid)
            {
				remindedPerson.Notify = true;
                db.RemindedPersons.Add(remindedPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(remindedPerson);
        }

        // GET: RemindedPersons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RemindedPerson remindedPerson = db.RemindedPersons.Find(id);
            if (remindedPerson == null)
            {
                return HttpNotFound();
            }
			return View(remindedPerson);
        }

        // POST: RemindedPersons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,NameDayDate,BirthdayDate,RemindBeforeInDays,RemindAt,Description,Notify")] RemindedPerson remindedPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(remindedPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(remindedPerson);
        }

        // GET: RemindedPersons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RemindedPerson remindedPerson = db.RemindedPersons.Find(id);
            if (remindedPerson == null)
            {
                return HttpNotFound();
            }
            return View(remindedPerson);
        }

        // POST: RemindedPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RemindedPerson remindedPerson = db.RemindedPersons.Find(id);
            db.RemindedPersons.Remove(remindedPerson);
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
