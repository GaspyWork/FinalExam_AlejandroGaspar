using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Services.Factory;

namespace InternationalBusinessMen.Services.FakeRepository
{
    public interface IFakeRepository
    {
        List<ConversionModelBD> listaConversion();
        List<TransacionModelBD> listaTransacion();
    }
}