using System.ComponentModel.DataAnnotations;

namespace InternationalBusinessMen.Models.BDModels
{
    public class ConversionModelBD : IAccion
    {
        [Key]
        public int Id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public double rate { get; set; }
    }
}