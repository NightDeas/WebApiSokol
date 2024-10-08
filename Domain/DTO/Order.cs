using Domain.DTO.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class Order : IConvertModel<Order, Api.DataBase.Models.Order>
    {
        public Guid Id { get; set; }
        public Guid UserId { get;set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }

        public Api.DataBase.Models.Order ConvertBLLToDALModel(Order DTOModel)
        {
            return new()
            {
                Count = DTOModel.Count,
                ProductId = DTOModel.ProductId,
                Sum = DTOModel.Sum,
                Id = DTOModel.Id,
                UserId  = DTOModel.UserId
            };
        }

        public Order ConvertDALToDTOModel(Api.DataBase.Models.Order DALModel)
        {
            return new()
            {
                Count = DALModel.Count,
                ProductId = DALModel.ProductId,
                Sum = DALModel.Sum,
                Id = DALModel.Id,
                UserId = DALModel.UserId
            };
        }
    }
}
