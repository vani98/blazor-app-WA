using Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}