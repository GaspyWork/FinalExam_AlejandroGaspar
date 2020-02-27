using System;
using System.Collections.Generic;
using System.Text;
using InternationalBusinessMen.Controllers;
using NUnit.Framework;

namespace IBMTest.ControllersTest
{
    public class ConversionControllerTest
    {
        private ConversionController controller = new ConversionController();

        [Test]
        public void CreateController()
        {
            var obj = new ConversionController();
            Assert.IsNotNull(obj);
        }

        [Test]
        public async void GetAllConversionesTest()
        {
            var res = await controller.GetAllConversiones();
            Assert.IsNotNull(res);
        }
    }
}
