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
    public class CarController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Car/

        public ViewResult Index()
        {
            return View(db.Cars.ToList());
        }

        //
        // GET: /Car/Details/5

        public ViewResult Details(Guid id)
        {
            Car car = db.Cars.Find(id);
            return View(car);
        }

        //
        // GET: /Car/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Car/Create

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                car.Id = Guid.NewGuid();
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(car);
        }
        
        //
        // GET: /Car/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            Car car = db.Cars.Find(id);
            return View(car);
        }

        //
        // POST: /Car/Edit/5

        [HttpPost]
        public ActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        //
        // GET: /Car/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            Car car = db.Cars.Find(id);
            return View(car);
        }

        //
        // POST: /Car/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {            
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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