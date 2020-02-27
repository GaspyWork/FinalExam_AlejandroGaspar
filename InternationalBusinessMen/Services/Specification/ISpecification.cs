using InternationalBusinessMen.Models.WebModels;

namespace InternationalBusinessMen.Services.Specification
{
    public interface ISpecification
    {
        bool IsSatisfiedBy(IModelAccion obj);
    }
}
