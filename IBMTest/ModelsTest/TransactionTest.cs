using System;
using System.Collections.Generic;
using System.Text;
using InternationalBusinessMen.Models.BDModels;
using NUnit.Framework;

namespace IBMTest.ModelsTest
{
    class TransactionTest
    {
        private TransacionModelBD model;

        [Test]
        public void Create()
        {
            model = new TransacionModelBD();
            Assert.IsNotNull(model);
        }
    }
}
