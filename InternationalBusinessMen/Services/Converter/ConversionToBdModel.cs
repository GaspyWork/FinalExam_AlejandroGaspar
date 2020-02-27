using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Models.WebModels;
using InternationalBusinessMen.Services.Excepciones;
using InternationalBusinessMen.Services.Factory;

namespace InternationalBusinessMen.Services.Converter
{
    public class ConversionToBdModel : IConverterConversion
    {
        //private ConversionFactory _accionConversion;

        //public ConversionToBdModel(ConversionFactory accionConversion)
        //{
        //    _accionConversion = accionConversion;
        //}

        public List<ConversionModelBD> ConvertTo(List<ConversionModel> lista)
        {
            try
            {
                List<ConversionModelBD> listaResult = new List<ConversionModelBD>();
                ConversionModelBD conversionobj;

                foreach (var item in lista)
                {
                    conversionobj = new ConversionModelBD()
                    {
                        from = item.from,
                        to = item.to,
                        rate = Convert.ToDouble(item.rate)
                    };

                    listaResult.Add(conversionobj);
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