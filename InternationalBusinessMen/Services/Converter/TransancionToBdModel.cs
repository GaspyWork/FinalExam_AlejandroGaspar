using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Models.WebModels;

namespace InternationalBusinessMen.Services.Converter
{
    public class TransancionToBdModel : IConverterTransacion
    {
        public List<TransacionModelBD> ConvertTo(List<TransacionModel> lista)
        {
            List<TransacionModelBD> listaResult = new List<TransacionModelBD>();
            TransacionModelBD conversionobj;

            foreach (var item in lista)
            {
                conversionobj = new TransacionModelBD()
                {
                    sku = item.sku,
                    amount = Convert.ToDouble(item.amount),
                    currency = item.currency
                };
                listaResult.Add(conversionobj);
            }
            return listaResult;
        }
    }
}