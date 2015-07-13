using maskup;
using maskup.POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace maskup.Controllers
{
    public class AirCondictionsController : Controller
    {
        private AirDbModel db = new AirDbModel();

        // GET: AirCondictions
        public ActionResult Index()
        {
            return View(db.AirCondictions.ToList());
        }

        // GET: AirCondictions/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirCondiction airCondiction = db.AirCondictions.Find(id);
            if (airCondiction == null)
            {
                return HttpNotFound();
            }
            return View(airCondiction);
        }

        //// GET: AirCondictions/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: AirCondictions/Create
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "id,location,locationCht,datetime,pm10,pm25,o3,so2,co,no2,fpmi")] AirCondiction airCondiction)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        airCondiction.id = Guid.NewGuid();
        //        db.AirCondictions.Add(airCondiction);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(airCondiction);
        //}

        //// GET: AirCondictions/Edit/5
        //public ActionResult Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AirCondiction airCondiction = db.AirCondictions.Find(id);
        //    if (airCondiction == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(airCondiction);
        //}

        //// POST: AirCondictions/Edit/5
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "id,location,locationCht,datetime,pm10,pm25,o3,so2,co,no2,fpmi")] AirCondiction airCondiction)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(airCondiction).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(airCondiction);
        //}

        //// GET: AirCondictions/Delete/5
        //public ActionResult Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AirCondiction airCondiction = db.AirCondictions.Find(id);
        //    if (airCondiction == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(airCondiction);
        //}

        //// POST: AirCondictions/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(Guid id)
        //{
        //    AirCondiction airCondiction = db.AirCondictions.Find(id);
        //    db.AirCondictions.Remove(airCondiction);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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