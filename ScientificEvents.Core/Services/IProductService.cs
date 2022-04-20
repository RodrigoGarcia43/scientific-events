using System.Collections.Generic;
using System.Threading.Tasks;
using ScientificEvents.Core.Dtos;


namespace ScientificEvents.Core.Services
{
    public interface IProductService
    {
        Task<ICollection<ProductDto>> ListAsync();
        Task<ProductDto> GetAsync(string id);
        Task<NewProductDto> CreateAsync(NewProductDto product);
        Task<bool> DeleteAsync(string id);
    }
}