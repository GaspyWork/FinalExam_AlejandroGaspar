using InternationalBusinessMen.Models.WebModels;
using InternationalBusinessMen.Services.Factory;
using InternationalBusinessMen.Services.Specification;
using NUnit.Framework;

namespace IBMTest.ServicesTest.FactoryTest

{
    public class TransacionFactoryTest
    {
        IConversionFactory _repoConvert = new ConversionFactory(new NotNullSpecification());

        [Test]
        public void Create()
        {
            var obj = _repoConvert.CreateInstance(new ConversionModel());
            Assert.IsNull(obj);
        }
    }
}
