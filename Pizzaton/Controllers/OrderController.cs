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
    public class OrderController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Order/

        public ViewResult Index()
        {
            return View(db.Orders.ToList());
        }

        //
        // GET: /Order/Details/5

        public ViewResult Details(Guid id)
        {
            Order order = db.Orders.Find(id);
            return View(order);
        }

        //
        // GET: /Order/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Order/Create

        [HttpPost]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                order.Id = Guid.NewGuid();
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(order);
        }
        
        //
        // GET: /Order/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            Order order = db.Orders.Find(id);
            return View(order);
        }

        //
        // POST: /Order/Edit/5

        [HttpPost]
        public ActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        //
        // GET: /Order/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            Order order = db.Orders.Find(id);
            return View(order);
        }

        //
        // POST: /Order/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
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