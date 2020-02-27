using System.Threading.Tasks;

namespace InternationalBusinessMen.Services.API.WebAPI
{
    public interface IWebAPIGetData
    {
         Task<string> DescargarDatos(string ruta);
    }
}
