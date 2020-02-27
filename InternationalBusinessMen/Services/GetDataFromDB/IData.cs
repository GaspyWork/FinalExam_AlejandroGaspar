using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.Services.GetDataFromDB
{
    public interface IData
    {
        Task<string> GetAllrates();
        Task<string> GetAllTransactions();
        List<TransacionModelBD> GettransacionBySKU(string sku);
    }
}
