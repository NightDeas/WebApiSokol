using Api.DataBase;
using Api.DataBase.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Services;

namespace Domain.Services
{
    public class OrderService
    {
        OrderRepository Repository;

        public OrderService(OrderRepository repository)
        {
            Repository = repository;
        }

        public async Task<Guid> PostAsync(Order order)
        {
            return await Repository.PostAsync(new Order().ConvertBLLToDALModel(order)); 
        }
    }
}
