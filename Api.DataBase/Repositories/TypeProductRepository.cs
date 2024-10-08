using Api.DataBase.Repositories.Interfaces;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase.Repositories
{
    public class TypeProductRepository : ITypeProductRepository
    {
        Context Context;

        public TypeProductRepository(Context context)
        {
            Context = context;
        }

        public async Task<Guid> GetIdProduct()
        {
            var type = await Context.TypeProducts.FirstOrDefaultAsync(x => x.Name == "Товар");
            return type.Id;
        }

        public async Task<Guid> GetIdService()
        {
            var type = await Context.TypeProducts.FirstOrDefaultAsync(x => x.Name == "Услуга");
            return type.Id;
        }
    }
}
