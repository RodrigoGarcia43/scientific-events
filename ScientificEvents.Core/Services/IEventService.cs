using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.Core.Dtos;


namespace ScientificEvents.Core.Services
{
    public interface IEventService
    {
        Task<ICollection<SummaryEventDto>> ListAsync();
        Task<EventDto> GetAsync(string code);
        Task<EventDto> CreateAsync(NewEventDto event_);
        Task<bool> DeleteAsync(string code);
    }
}