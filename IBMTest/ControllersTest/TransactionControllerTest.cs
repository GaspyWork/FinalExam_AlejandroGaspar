using System;
using System.Collections.Generic;
using System.Text;
using InternationalBusinessMen.Controllers;
using NUnit.Framework;

namespace IBMTest.ControllersTest
{
    public class TransactionControllerTest
    {
        private TransacionController controller = new TransacionController();

        [Test]
        public void CreateController()
        {
            var obj = new TransacionController();
            Assert.IsNotNull(obj);
        }

        [Test]
        public async void GetAllConversionesTest()
        {
            var res = await controller.GetAllTransaciones();
            Assert.IsNotNull(res);
        }
    }
}
