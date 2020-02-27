﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternationalBusinessMen.Models.BDModels;
using InternationalBusinessMen.Models.WebModels;

namespace InternationalBusinessMen.Services.Converter
{
    public interface IConverterTransacion
    {
        Task<List<TransacionModelBD>> ConvertToBdModel(List<TransacionModel> lista);
    }
}
