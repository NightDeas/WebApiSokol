using Microsoft.EntityFrameworkCore.Storage;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class Product : Interfaces.IConvertModel<Product, Api.DataBase.Models.Product>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TypeId { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public Api.DataBase.Models.Product ConvertBLLToDALModel(Product DTOModel)
        {
            return new()
            {
                Id = DTOModel.Id,
                Count = DTOModel.Count,
                Name = DTOModel.Name,
                Price = DTOModel.Price,
                TypeId = DTOModel.TypeId,
            };
        }

        public Product ConvertDALToDTOModel(Api.DataBase.Models.Product DALModel)
        {
            return new()
            {
                Id = DALModel.Id,
                Count = DALModel.Count,
                Name = DALModel.Name,
                Price = DALModel.Price,
                TypeId = DALModel.TypeId,
            };
        }
    }
}
