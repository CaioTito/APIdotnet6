using Wiz.Teste1.Domain.Models.Services;

namespace Wiz.Template.Domain.Interfaces.HttpService
{
    public interface IViaCEPHttpService
    {
        Task<ViaCEP> GetByCEPAsync(string cep);
    }
}
