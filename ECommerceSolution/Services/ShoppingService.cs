using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using Service;

namespace Services
{
    public class ShoppingService : IShoppingService
    {
        private readonly ECommerceDbContext _context;

        public ShoppingService(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<Item> AddItem(Item item)
        {
            await _context.items.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;

        }

        public Item DeleteItem(int id)
        {
            var item = _context.items.FirstOrDefault(x => x.Id == id);

            if (item != null)
            {
                _context.items.Remove(item);
                _context.SaveChanges();
                return item;
            }
            throw new ItemException("Item not found");
        }

        public async Task<List<Item>> GetAllItems()
        {
            return await _context.items.ToListAsync();
        }

        public async Task<List<Item>> GetAllItemsWithPriceMoreThan(decimal a)
        {
            return await _context.items.Where(x =>x.Price >a).ToListAsync();  
        }

        
    }
}