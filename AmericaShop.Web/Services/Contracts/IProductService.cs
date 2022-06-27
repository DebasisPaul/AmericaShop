using AmericaShop.Models.Dtos;

namespace AmericaShop.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
