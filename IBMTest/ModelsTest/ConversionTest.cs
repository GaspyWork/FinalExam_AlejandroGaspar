﻿using System;
using System.Collections.Generic;
using System.Text;
using InternationalBusinessMen.Models.BDModels;
using NUnit.Framework;

namespace IBMTest.ModelsTest
{
    public class ConversionTest
    {
        private ConversionModelBD model;

        [Test]
        public void Create()
        {
            model = new ConversionModelBD();
            Assert.IsNotNull(model);
        }
    }
}
