using Api.DataBase;
using Api.DataBase.Repositories;
using Api.DataBase.Repositories.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;

namespace Domain.Services
{
    public class ProductService
    {
        ProductRepository Repository { get; set; }

        public ProductService(ProductRepository repository)
        {
            Repository = repository;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            var DALModels = await Repository.GetAllAsync();
            var DTOModels = DALModels.Select(x => new Product().ConvertDALToDTOModel(x)).ToList();
            return DTOModels;
        }

        public async Task<Product> GetAsync(Guid id)
        {
            return new Product().ConvertDALToDTOModel(await Repository.GetAsync(id));
        }

        public async Task<int> GetCount(Guid id)
        {
            return await Repository.GetCount(id);
        }

        public async Task<Guid> PostAsync(Product product)
        {
            return await Repository.PostAsync(product.ConvertBLLToDALModel(product));
        }

        public async Task<int> UpdateCountAsync(Guid id, int newCount)
        {
          return await Repository.UpdateCountAsync(id, newCount);
        }


    }
}
