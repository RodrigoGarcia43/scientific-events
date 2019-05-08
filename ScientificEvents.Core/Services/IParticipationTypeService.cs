using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.Core.Dtos;


namespace ScientificEvents.Core.Services
{
    public interface IParticipationTypeService
    {
        Task<IEnumerable<ParticipationTypeDto>> ListAsync();
        Task<ParticipationTypeDto> GetAsync(string id);
        Task<NewParticipationTypeDto> CreateAsync(NewParticipationTypeDto participationType);
        Task<bool> DeleteAsync(string id);
    }
}