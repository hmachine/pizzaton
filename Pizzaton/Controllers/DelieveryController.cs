using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzaton.Core.Models;
using Pizzaton.Core;

namespace Pizzaton.Controllers
{ 
    public class DelieveryController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Delievery/

        public ViewResult Index()
        {
            return View(db.Delieveries.ToList());
        }

        //
        // GET: /Delievery/Details/5

        public ViewResult Details(Guid id)
        {
            Delievery delievery = db.Delieveries.Find(id);
            return View(delievery);
        }

        //
        // GET: /Delievery/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Delievery/Create

        [HttpPost]
        public ActionResult Create(Delievery delievery)
        {
            if (ModelState.IsValid)
            {
                delievery.Id = Guid.NewGuid();
                db.Delieveries.Add(delievery);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(delievery);
        }
        
        //
        // GET: /Delievery/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            Delievery delievery = db.Delieveries.Find(id);
            return View(delievery);
        }

        //
        // POST: /Delievery/Edit/5

        [HttpPost]
        public ActionResult Edit(Delievery delievery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(delievery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(delievery);
        }

        //
        // GET: /Delievery/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            Delievery delievery = db.Delieveries.Find(id);
            return View(delievery);
        }

        //
        // POST: /Delievery/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            Delievery delievery = db.Delieveries.Find(id);
            db.Delieveries.Remove(delievery);
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