using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.API.Domain.Models;

namespace ScientificEvents.Core.Services
{
    public interface IEventService
    {
        Task<IEnumerable<EventDto>> ListAsync();
        Task<EventDto> GetAsync(string id);
        Task<NewEventDto> CreateAsync(NewEventDto event_);
        Task<bool> DeleteAsync(string id);
    }
}