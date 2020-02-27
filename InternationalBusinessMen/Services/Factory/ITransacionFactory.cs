using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Models.WebModels;

namespace InternationalBusinessMen.Services.Factory
{
    public interface ITransacionFactory
    {
        Task<TransacionModelBD> CreateInstance(TransacionModel transacion);
    }
}
