using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Services;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> ListAsync()
        {
            
        }
    }
}