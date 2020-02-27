using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.Services.Factory
{
    public class TransactionFactory : IAccionFactory<TransacionModelBD>
    {
        public IAccion CreateInstance()
        {
            return new TransacionModelBD();
        }

        public IAccion CreateInstance(string sku, double amount, string currency)
        {
            return new TransacionModelBD()
            {
                sku = sku,
                amount = amount,
                currency = currency
                
            };
        }
    }
}