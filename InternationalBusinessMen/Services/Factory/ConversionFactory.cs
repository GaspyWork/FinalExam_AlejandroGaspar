using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.Services.Factory
{
    public class ConversionFactory : IAccionFactory<ConversionModelBD>
    {
        public IAccion CreateInstance()
        {
            IAccion accion = new ConversionModelBD()
            {

            };
            return accion;
        }

        public IAccion CreateInstance(ConversionModelBD obj)
        {
            IAccion accion = new ConversionModelBD()
            {
                from = obj.from,
                to = obj.to,
                rate = obj.rate
            };

            return accion;
        }
    }
}