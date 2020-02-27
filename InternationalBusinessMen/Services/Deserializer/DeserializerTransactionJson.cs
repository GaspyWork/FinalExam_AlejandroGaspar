using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.WebModels;
using InternationalBusinessMen.Services.Excepciones;
using Newtonsoft.Json;

namespace InternationalBusinessMen.Services.Deserializer
{
    public class DeserializerTransactionJson : IDeserializer
    {
        public List<TransacionModel> ConvertTo<TransacionModel>(string body)
        {
            try
            {
                var listaJson = JsonConvert.DeserializeObject<List<TransacionModel>>(body);
                return listaJson;
            }
            catch (Exception e)
            {

                throw new ErrorConvertException("Error al convertir a json", e);
            }
        }
    }
}