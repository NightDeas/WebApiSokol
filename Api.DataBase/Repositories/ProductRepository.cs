using Api.DataBase.Models;
using Api.DataBase.Repositories.Interfaces;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase.Repositories
{
    public class ProductRepository : IProductRepository
    {
        Context Context { get; set; }

        public ProductRepository(Context context)
        {
            Context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await Context.Products
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Product> GetAsync(Guid id)
        {
            return await Context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> GetCount(Guid id)
        {
            var product = await GetAsync(id);
            if (product == null)
                return -1;
            return product.Count;
        }

        public async Task<Guid> PostAsync(Product product)
        {
            var newProduct = new Product()
            {
                Name = product.Name,
                Count = product.Count,
                TypeId = product.TypeId,
                Price = product.Price,
            };
            await Context.Products.AddAsync(newProduct);
            await Context.SaveChangesAsync();
            return newProduct.Id;
        }

        public async Task<int> UpdateCountAsync(Guid id, int newCount)
        {
            var product = await GetAsync(id);
            if (product == null)
                return -1;
            product.Count = newCount;
            await Context.SaveChangesAsync();
            return product.Count;
        }
    }
}
