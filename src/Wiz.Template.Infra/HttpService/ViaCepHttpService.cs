using System.Text.Json;
using Wiz.Template.Domain.Interfaces.HttpService;
using Wiz.Teste1.Domain.Models.Services;

namespace Wiz.Template.Infra.Services
{
    public class ViaCEPHttpService : IViaCEPHttpService
    {
        private readonly HttpClient _httpClient;

        public ViaCEPHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ViaCEP> GetByCEPAsync(string cep)
        {
            ViaCEP result = null;

            HttpResponseMessage response = await _httpClient.GetAsync($"{cep}/json", HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            try
            {
                if (response.Content is object)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    result = await JsonSerializer.DeserializeAsync<ViaCEP>(stream);
                }
            }
            finally
            {
                response.Dispose();
            }

            return result;
        }
    }
}
