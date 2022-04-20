
using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.Core.Dtos;

namespace ScientificEvents.Core.Services
{
    public interface IPersonService
    {
        Task<ICollection<PersonDto>> ListAsync();
        Task<PersonDto> GetAsync(string id);
        Task<NewPersonDto> CreateAsync(NewPersonDto person);
        Task<bool> DeleteAsync(string id);
    }
}