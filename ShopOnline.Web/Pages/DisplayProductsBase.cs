using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using System.Globalization;

namespace ShopOnline.Web.Pages
{
    public class DisplayProductsBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
