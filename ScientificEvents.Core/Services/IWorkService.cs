using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.Core.Dtos;


namespace ScientificEvents.Core.Services
{
    public interface IWorkService
    {
        Task<ICollection<WorkDto>> ListAsync(ICollection<string> ids);
        Task<WorkDto> GetAsync(string id);
        Task<NewWorkDto> CreateAsync(NewWorkDto work);
        Task<bool> DeleteAsync(string id);
    }
}