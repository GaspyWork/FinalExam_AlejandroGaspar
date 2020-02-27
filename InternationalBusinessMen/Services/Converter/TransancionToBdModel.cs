using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Models.WebModels;
using InternationalBusinessMen.Services.Excepciones;
using InternationalBusinessMen.Services.Factory;

namespace InternationalBusinessMen.Services.Converter
{
    public class TransancionToBdModel : IConverterTransacion
    {
        private ITransacionFactory _transacionfactory;

        public TransancionToBdModel(ITransacionFactory transacionFactory)
        {
            _transacionfactory = transacionFactory;
        }
        public async Task<List<TransacionModelBD>> ConvertToBdModel(List<TransacionModel> lista)
        {
            try
            {
                List<TransacionModelBD> listaResult = new List<TransacionModelBD>();

                foreach (var item in lista)
                {
                    listaResult.Add(await _transacionfactory.CreateInstance(item));
                }

                return listaResult;
            }
            catch (Exception ex)
            {
                throw new ErrorConvertException("No se ha podido convertir de ConversionModel a ConversionModelBD", ex);
            }
        }
    }
}