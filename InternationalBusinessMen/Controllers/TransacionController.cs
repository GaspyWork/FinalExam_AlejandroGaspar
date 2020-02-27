using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using InternationalBusinessMen.DAL;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Services.GetDataFromDB;
using InternationalBusinessMen.Services.TransferirDatos;

namespace InternationalBusinessMen.Controllers
{
    public class TransacionController : Controller
    {
        private IBMContext db = new IBMContext();
        private readonly IData _datos;

        public TransacionController()
        {
            
        }
        public TransacionController(IData datos)
        {
            _datos = datos;
        }

        // GET: TransacionModelBDs
        public ActionResult Index()
        {
            return View(db.Transaciones.ToList());
        }

        public async Task<ActionResult> GetAllTransaciones()
        {
            try
            {
                string result = await _datos.GetAllTransactions();
                return Content(result);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(500);
            }
        }

        // GET: TransacionModelBDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransacionModelBD transacionModelBD = db.Transaciones.Find(id);
            if (transacionModelBD == null)
            {
                return HttpNotFound();
            }
            return View(transacionModelBD);
        }

        // GET: TransacionModelBDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransacionModelBDs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,sku,amount,currency")] TransacionModelBD transacionModelBD)
        {
            if (ModelState.IsValid)
            {
                db.Transaciones.Add(transacionModelBD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transacionModelBD);
        }

        // GET: TransacionModelBDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransacionModelBD transacionModelBD = db.Transaciones.Find(id);
            if (transacionModelBD == null)
            {
                return HttpNotFound();
            }
            return View(transacionModelBD);
        }

        // POST: TransacionModelBDs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,sku,amount,currency")] TransacionModelBD transacionModelBD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transacionModelBD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transacionModelBD);
        }

        // GET: TransacionModelBDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransacionModelBD transacionModelBD = db.Transaciones.Find(id);
            if (transacionModelBD == null)
            {
                return HttpNotFound();
            }
            return View(transacionModelBD);
        }

        // POST: TransacionModelBDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TransacionModelBD transacionModelBD = db.Transaciones.Find(id);
            db.Transaciones.Remove(transacionModelBD);
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
