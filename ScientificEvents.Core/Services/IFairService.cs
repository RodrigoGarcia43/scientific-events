using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.Core.Dtos;


namespace ScientificEvents.Core.Services
{
    public interface IFairService
    {
        Task<ICollection<FairDto>> ListAsync();
        Task<FairDto> GetfairfairfairfairAsync(string id);
        Task<NewFairDto> CreateAsync(NewFairDto fair);
        Task<bool> DeleteAsync(string id);
    }
}