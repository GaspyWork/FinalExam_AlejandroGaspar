using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.Services.Factory
{
    public interface IAccionFactory<T> where T : class
    {
        IAccion CreateInstance();
    }
}
