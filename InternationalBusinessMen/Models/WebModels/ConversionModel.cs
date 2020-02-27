namespace InternationalBusinessMen.Models.WebModels
{
    public class ConversionModel : IModelAccion
    {
        public string from { get; set; }
        public string to { get; set; }
        public string rate { get; set; }
    }
}