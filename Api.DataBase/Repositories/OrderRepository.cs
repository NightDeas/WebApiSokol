using Api.DataBase.Models;
using Api.DataBase.Repositories.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        Context Context;

        public OrderRepository(Context context)
        {
            Context = context;
        }

        public async Task<Guid> PostAsync(Order order)
        {
            var newOrder = new Order()
            {
                Count = order.Count,
                ProductId = order.ProductId,
                UserId = order.UserId,
                Sum = order.Sum,
            };
            await Context.Orders.AddAsync(newOrder);
            await Context.SaveChangesAsync();
            return newOrder.Id;
        }
    }
}
