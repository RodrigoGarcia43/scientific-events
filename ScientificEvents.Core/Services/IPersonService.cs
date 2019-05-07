
using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.API.Domain.Models;

namespace ScientificEvents.Core.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDto>> ListAsync();
        Task<PersonDto> GetAsync(string id);
        Task<NewPersonDto> CreateAsync(NewPersonDto person);
        Task<bool> DeleteAsync(string id);
    }
}