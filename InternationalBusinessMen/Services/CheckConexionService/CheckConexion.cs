using System;
using System.Net.Http;
using System.Threading.Tasks;
using Polly;

namespace InternationalBusinessMen.Services.CheckConexionService
{
    public class CheckConexion : ICheckConexion
    {
        public async Task<bool> Check(string url)
        {
            var httpClient = new HttpClient();
            var request = await Policy
                .HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                .WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(2), (result, timeSpan, retryCount, context) =>
                {
                    Console.WriteLine("Escribir en Log");
                    //logger.Warning($"Request failed with {result.Result.StatusCode}. Waiting {timeSpan} before next retry. Retry attempt {retryCount}");
                })
                .ExecuteAsync(() => httpClient.GetAsync(url));

            return request.IsSuccessStatusCode;
        }

    }
}