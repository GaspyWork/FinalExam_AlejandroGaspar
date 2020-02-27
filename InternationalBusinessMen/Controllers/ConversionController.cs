using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using InternationalBusinessMen.DAL;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Services.GetDataFromDB;
using InternationalBusinessMen.Services.Log;
using InternationalBusinessMen.Services.TransferirDatos;

namespace InternationalBusinessMen.Controllers
{
    public class ConversionController : Controller
    {

        private readonly ITransferirDatos _transferirData;
        private readonly IData _datos;

        public ConversionController()
        {
            
        }

        public ConversionController(ITransferirDatos transferirData, IData datos )
        {
            _transferirData = transferirData;
            _datos = datos;
        }

        // GET: ConversionModelBDs
        public async Task<ActionResult> GetAllData()
        {
            try
            {
                await _transferirData.TransferirData();
                return new HttpStatusCodeResult(200);
            }
            catch (Exception)
            {
                return new HttpStatusCodeResult(500);
            }
        }

        public async Task<ActionResult> GetAllConversiones()
        {
            try
            {
                string result = await _datos.GetAllrates();

                return Content(result);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(500);
            }
        }
    }
}
