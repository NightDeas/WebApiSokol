using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase.Repositories.Interfaces
{
    public interface ITypeProductRepository
    {
        Task<Guid> GetIdProduct();
        Task<Guid> GetIdService();
    }
}
