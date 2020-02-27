using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.WebModels;
using InternationalBusinessMen.Services.Excepciones;
using Newtonsoft.Json;

namespace InternationalBusinessMen.Services.Deserializer
{
    public class DeserializerConversionJson : IDeserializer
    {
        public List<ConversionModel> ConvertTo<ConversionModel>(string body)
        {
            try
            {
                var listaJson = JsonConvert.DeserializeObject<List<ConversionModel>>(body);
                return listaJson;
            }
            catch (Exception e) {

                throw new ErrorConvertException("Error al convertir a json", e);
            }
        }
    }
}