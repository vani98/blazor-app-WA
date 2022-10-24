using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Models;
using Newtonsoft.Json;

namespace Blazor.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)

        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Product>>(
            await _httpClient.GetStringAsync($"products"));
        }
    }
}