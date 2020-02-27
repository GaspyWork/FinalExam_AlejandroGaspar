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
    public class ConversionFactory : IConversionFactory
    {
        private ISpecification _specificationNull;

        public ConversionFactory(ISpecification specificationNull)
        {
            _specificationNull = specificationNull;
        }

        public async Task<ConversionModelBD> CreateInstance(ConversionModel conversion)
        {
            try
            {
                if (_specificationNull.IsSatisfiedBy(conversion))
                {
                    return await Task.Run(() => new ConversionModelBD()
                    {
                        from = conversion.from,
                        to = conversion.to,
                        rate = Convert.ToDouble(conversion.rate)

                    });
                }
                throw new NullException("La conversion no es correcta");
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }
    }
}