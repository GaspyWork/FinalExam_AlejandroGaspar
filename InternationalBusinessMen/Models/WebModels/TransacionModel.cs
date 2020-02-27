namespace InternationalBusinessMen.Models.WebModels
{
    public class TransacionModel : IModelAccion
    {
        public string sku { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
    }
}