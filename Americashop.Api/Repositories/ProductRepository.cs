using AmericaShop.Api.Data;
using AmericaShop.Api.Entities;
using AmericaShop.Api.Repositories.contracts;
using Microsoft.EntityFrameworkCore;

namespace AmericaShop.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AmericaShopDbContext americaShopDbContext;

        public ProductRepository(AmericaShopDbContext americaShopDbContext)
        {
            this.americaShopDbContext = americaShopDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var Categories = await  this.americaShopDbContext.ProductCategories.ToListAsync();
            return Categories;
        }

        public Task<ProductCategory> GetCategories(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItem()
        {
            var products = await this.americaShopDbContext.Products.ToListAsync();
            return products;
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
