using System.Threading.Tasks;
using Wiz.Teste1.Domain.Models.Services;

namespace Wiz.Teste1.Domain.Interfaces.Services
{
    public interface IViaCEPService
    {
        Task<ViaCEP> GetByCEPAsync(string cep);
    }
}
