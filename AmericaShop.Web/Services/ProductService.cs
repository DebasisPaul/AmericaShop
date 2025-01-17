﻿using AmericaShop.Models.Dtos;
using AmericaShop.Web.Services.Contracts;
using System.Net.Http.Json;

namespace AmericaShop.Web.Services
{
    public class ProductService:IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
