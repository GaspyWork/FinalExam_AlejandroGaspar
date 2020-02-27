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
    public class ConversionToBdModel : IConverterConversion
    {
        private readonly IConversionFactory _Conversionfactory;

        public ConversionToBdModel(IConversionFactory conversionfactory)
        {
            _Conversionfactory = conversionfactory;
        }

        public async Task<List<ConversionModelBD>> ConvertToBdModel(List<ConversionModel> lista)
        {
            try
            {
                List<ConversionModelBD> listaResult = new List<ConversionModelBD>();

                foreach (var item in lista)
                {
                    listaResult.Add(await _Conversionfactory.CreateInstance(item).ConfigureAwait(false));
                }
                return listaResult;
            }
            catch (Exception ex)
            {
                throw new ErrorConvertException("No se ha podido convertir de ConversionModel a ConversionModelBD",ex);
            }
        }
    }
}