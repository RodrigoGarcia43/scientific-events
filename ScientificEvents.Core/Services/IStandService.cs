using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.Core.Dtos;


namespace ScientificEvents.Core.Services
{
    public interface IStandService
    {
        Task<IEnumerable<StandDto>> ListAsync();
        Task<StandDto> GetAsync(string id);
        Task<NewStandDto> CreateAsync(NewStandDto stand);
        Task<bool> DeleteAsync(string id);
    }
}