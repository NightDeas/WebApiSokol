using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<Models.Product> GetAsync(Guid id);
        Task<List<Models.Product>> GetAllAsync();
        Task<Guid> PostAsync(Models.Product product);
        Task<int> UpdateCountAsync(Guid id, int newCount);
        Task<int> GetCount(Guid id);
    }
}
