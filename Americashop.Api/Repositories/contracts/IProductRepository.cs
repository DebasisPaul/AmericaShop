using AmericaShop.Api.Entities;

namespace AmericaShop.Api.Repositories.contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItem();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItem(int id);
        Task<ProductCategory> GetCategories(int id);
    }
}
