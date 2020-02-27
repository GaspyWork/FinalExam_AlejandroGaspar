using InternationalBusinessMen.Models.WebModels;

namespace InternationalBusinessMen.Services.Specification
{
    public class NotNullSpecification : ISpecification
    {
        public bool IsSatisfiedBy(IModelAccion obj)
        {
            if (obj == null)
            {
                return false;
            }

            return true;
        }
    }
}