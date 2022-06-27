using AmericaShop.Models.Dtos;
using AmericaShop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace AmericaShop.Web.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}
