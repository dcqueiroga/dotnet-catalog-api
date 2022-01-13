using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories {
    public class InMemItemsRepository : IItemsRepository {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Portion", Price = 9, CreatedDate = System.DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = System.DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Chield", Price = 18, CreatedDate = System.DateTimeOffset.UtcNow }
        };

        public IEnumerable<Item> GetItems() {
            return items;
        }

        public Item GetItem(Guid Id) {
            return items.Where(item => item.Id == Id).SingleOrDefault();
        }
    }
}