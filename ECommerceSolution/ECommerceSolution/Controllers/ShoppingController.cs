using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ECommerceSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingService _shoppingService;

        public ShoppingController(IShoppingService shoppingService)
        {
            _shoppingService = shoppingService;
        }

        // Get All Products

        [HttpGet("/items")]
        public async Task<List<Item>> GetAllItems()
        {
            return await _shoppingService.GetAllItems();
        }

        
        // Add new product
        [HttpPost("/items")]
        public async Task<Item> AddItem([FromBody] Item item)
        {
            return await _shoppingService.AddItem(item);
        }

       
        //Delete product by Id
        [HttpDelete("/items/{id}")]
        public Item DeleteItem(int id)
        {
            return _shoppingService.DeleteItem(id);
        }

        //Get products with price more than A
        [HttpGet("/items/{a}")]
        public async Task<List<Item>> GetAllItemsWithPriceMoreThan(decimal a)
        {
            return await _shoppingService.GetAllItemsWithPriceMoreThan(a);
        }


    }
}