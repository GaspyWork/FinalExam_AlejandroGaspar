using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Models.WebModels;
using InternationalBusinessMen.Services.Excepciones;
using InternationalBusinessMen.Services.Specification;

namespace InternationalBusinessMen.Services.Factory
{
    public class TransactionFactory : ITransacionFactory
    {
        private ISpecification _specificationNull;

        public TransactionFactory(ISpecification specificationNull)
        {
            _specificationNull = specificationNull;
        }
        public async Task<TransacionModelBD> CreateInstance(TransacionModel transacion)
        {
            try
            {
                if (_specificationNull.IsSatisfiedBy(transacion))
                {
                    return new TransacionModelBD()
                    {
                        sku = transacion.sku,
                        amount = Convert.ToDouble(transacion.amount),
                        currency = transacion.currency
                    };
                }

                throw new NullException("La transacion no es correcta");
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}