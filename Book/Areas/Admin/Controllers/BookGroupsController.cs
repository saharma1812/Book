using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace Book.Areas.Admin.Controllers
{
    public class BookGroupsController : Controller    
    {
     
        private IBookGroupRepository bookGroupRepository;
        MyCmsContext db = new MyCmsContext();
        public BookGroupsController()
        {
            bookGroupRepository = new BookGroupRepository(db); 
        }

        // GET: Admin/BookGroups
        public ActionResult Index()
        {
            return View(bookGroupRepository.GetAllGroups());
        }

        // GET: Admin/BookGroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookGroup bookGroup = bookGroupRepository.GetGroupById(id.Value);
            if (bookGroup == null)
            {
                return HttpNotFound();
            }
            return View(bookGroup);
        }

        // GET: Admin/BookGroups/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Admin/BookGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GroupID,GroupTitle")] BookGroup bookGroup)
        {
            if (ModelState.IsValid)
            {
                bookGroupRepository.InsertGroup(bookGroup);
                bookGroupRepository.save();
                return RedirectToAction("Index");
            }

            return View(bookGroup);
        }

        // GET: Admin/BookGroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookGroup bookGroup = bookGroupRepository.GetGroupById(id.Value);
            if (bookGroup == null)
            {
                return HttpNotFound();
            }
            return PartialView(bookGroup);
        }

        // POST: Admin/BookGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GroupID,GroupTitle")] BookGroup bookGroup)
        {
            if (ModelState.IsValid)
            {
                bookGroupRepository.UpdateGroup(bookGroup);
                bookGroupRepository.save();
                return RedirectToAction("Index");
            }
            return View(bookGroup);
        }

        // GET: Admin/BookGroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookGroup bookGroup = bookGroupRepository.GetGroupById(id.Value);
            if (bookGroup == null)
            {
                return HttpNotFound();
            }
            return PartialView(bookGroup);
        }

        // POST: Admin/BookGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bookGroupRepository.DeleteGroup(id);
            bookGroupRepository.save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                bookGroupRepository.Dispose();
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
