using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IShoppingService
    {
        public Task<List<Item>> GetAllItems();
        public Task<List<Item>> GetAllItemsWithPriceMoreThan(decimal a);
        public Task<Item> AddItem(Item item);
        public Item DeleteItem(int id);

    }
}
