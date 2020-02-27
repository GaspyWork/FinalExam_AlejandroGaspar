using System.Threading.Tasks;

namespace InternationalBusinessMen.Services.API.WebAPI
{
    public interface IWebAPIRepository
    {
         Task<string> DescargarDatos(string ruta);
    }
}
