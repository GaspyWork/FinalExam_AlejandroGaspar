using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using InternationalBusinessMen.DAL;
using InternationalBusinessMen.Services.Excepciones;

namespace InternationalBusinessMen.Services.API.WebAPI
{
    public class WebAPIRepository : IWebAPIRepository
    {
        HttpClient _client;

        public WebAPIRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> DescargarDatos(string ruta)
        {
            try
            {
                    HttpResponseMessage response = await _client.GetAsync(ruta).ConfigureAwait(false);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return responseBody;
            }
            catch (Exception e)
            {
                    throw new ErrorConexionException("Error de Conexion con el WebService", e);
            }
        }
    }
}