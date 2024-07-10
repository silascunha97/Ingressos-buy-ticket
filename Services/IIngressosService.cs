using Ingressos.Models;

namespace Ingressos.Services
{
  public interface IIngressosService
    {
        Task<IEnumerable<Ingresso>> GetIngressosAsync();
        Task<IEnumerable<Ingresso>> GetIngressosByEventoIdAsync(int eventoId);
        Task<Ingresso> ComprarIngressoAsync(Ingresso ingresso);
        Task<Ingresso> ReservarIngressoAsync(Ingresso ingresso);
    }
}
