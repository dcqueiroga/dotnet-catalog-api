using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Entities;

namespace Catalog.Repositories {
    public class InMemItemsRepository : IItemsRepository {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Portion", Price = 9, CreatedDate = System.DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = System.DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Chield", Price = 18, CreatedDate = System.DateTimeOffset.UtcNow }
        };

        public async Task<IEnumerable<Item>> GetItemsAsync() {
            return items;
        }

        public async Task<Item> GetItemAsync(Guid Id) {
            return items.Where(item => item.Id == Id).SingleOrDefault();
        }

        public async Task CreateItemAsync(Item item)
        {
            items.Add(item);
        }

        public async Task UpdateItemAsync(Item item)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[index] = item;
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(index);
        }
    }
}