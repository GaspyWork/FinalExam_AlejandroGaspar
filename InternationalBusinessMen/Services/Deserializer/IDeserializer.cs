using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternationalBusinessMen.Models.WebModels;

namespace InternationalBusinessMen.Services.Deserializer
{
    public interface IDeserializer
    {
        List<T> ConvertTo<T>(string body);
    }
}
