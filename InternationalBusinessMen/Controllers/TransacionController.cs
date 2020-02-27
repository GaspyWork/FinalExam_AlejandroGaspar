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

        public async Task<ActionResult> RecogerTodasTransaciones()
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
    }
}
