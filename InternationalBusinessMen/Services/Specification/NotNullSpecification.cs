using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Services.Excepciones;

namespace InternationalBusinessMen.Specification
{
    public class NotNullSpecification : ISpecification
    {
        public bool IsSatisfiedBy(IAccion obj)
        {
            if (obj == null)
            {
                return false;
            }

            return true;
        }
    }
}