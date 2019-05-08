using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.Core.Dtos;


namespace ScientificEvents.Core.Services
{
    public interface IEventTypeService
    {
        Task<IEnumerable<EventTypeDto>> ListAsync();
        Task<EventTypeDto> GetAsync(string id);
        Task<NewEventTypeDto> CreateAsync(NewEventTypeDto eventType);
        Task<bool> DeleteAsync(string id);
    }
}