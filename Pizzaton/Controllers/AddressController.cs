using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pizzaton.Models;
using Pizzaton.Core;

namespace Pizzaton.Controllers
{ 
    public class AddressController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Address/

        public ViewResult Index()
        {
            return View(db.Addresses.ToList());
        }

        //
        // GET: /Address/Details/5

        public ViewResult Details(Guid id)
        {
            Address address = db.Addresses.Find(id);
            return View(address);
        }

        //
        // GET: /Address/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Address/Create

        [HttpPost]
        public ActionResult Create(Address address)
        {
            if (ModelState.IsValid)
            {
                address.Id = Guid.NewGuid();
                db.Addresses.Add(address);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(address);
        }
        
        //
        // GET: /Address/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            Address address = db.Addresses.Find(id);
            return View(address);
        }

        //
        // POST: /Address/Edit/5

        [HttpPost]
        public ActionResult Edit(Address address)
        {
            if (ModelState.IsValid)
            {
                db.Entry(address).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(address);
        }

        //
        // GET: /Address/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            Address address = db.Addresses.Find(id);
            return View(address);
        }

        //
        // POST: /Address/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            Address address = db.Addresses.Find(id);
            db.Addresses.Remove(address);
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