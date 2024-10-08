using Api.DataBase;
using Api.DataBase.Repositories;

using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Services
{
    public class TypeProductService
    {
        TypeProductRepository Repository;

        public TypeProductService(TypeProductRepository repository)
        {
            Repository = repository;
        }

        public async Task<Guid> GetIdProduct()
        {
            return await Repository.GetIdProduct();
        }

        public async Task<Guid> GetIdService()
        {
            return await Repository.GetIdProduct();
        }
    }
}
