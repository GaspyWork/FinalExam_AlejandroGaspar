using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternationalBusinessMen.Models.BDModels;

namespace InternationalBusinessMen.Specification
{
    public interface ISpecification
    {
        bool IsSatisfiedBy(IAccion obj);
    }
}
