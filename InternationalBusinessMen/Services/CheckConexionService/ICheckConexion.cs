using System.Threading.Tasks;

namespace InternationalBusinessMen.Services.CheckConexionService
{
    public interface ICheckConexion
    {
        Task<bool> Check(string url);
    }
}
