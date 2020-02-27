using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.Services.FakeRepository
{
    public interface IFakeRepository
    {
        void List<IAccion> CrearListaConversion();

        void CrearListaTransacion();
    }
}