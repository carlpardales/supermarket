using System.Threading.Tasks;
using System.Collections.Generic;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}