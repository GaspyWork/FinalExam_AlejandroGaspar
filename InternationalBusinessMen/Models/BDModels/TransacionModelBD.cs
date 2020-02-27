using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternationalBusinessMen.Models.BDModels
{
    public class TransacionModelBD : IAccion
    {
        [Key]
        public int Id { get; set; }
        public string sku { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
    }
}