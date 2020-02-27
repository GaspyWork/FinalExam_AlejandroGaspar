using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.Services.FakeRepository
{
    public class FakeRepository : IFakeRepository
    {
        public List<ConversionModelBD> listaConversion()
        {
            List<ConversionModelBD> lista = new List<ConversionModelBD>()
            {
                new ConversionModelBD(){from = "EU",rate = 5.00,to = "CAD"},
                new ConversionModelBD(){from = "USD",rate = 6.00,to = "EU"},
                new ConversionModelBD(){from = "CAD",rate = 4.00,to = "USD"}
            };
            return lista;
        }

        public List<TransacionModelBD> listaTransacion()
        {
            List<TransacionModelBD> lista = new List<TransacionModelBD>()
            {
                new TransacionModelBD(){sku = "T2980",amount = 20.00,currency = "USD"},
                new TransacionModelBD(){sku = "T2970",amount = 30.00,currency = "EU"},
                new TransacionModelBD(){sku = "T2960",amount = 40.00,currency = "CAD"},
            };
            return lista;
        }
    }
}