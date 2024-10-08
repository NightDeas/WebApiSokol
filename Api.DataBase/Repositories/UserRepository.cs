using Api.DataBase.Models;
using Api.DataBase.Repositories.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase.Repositories
{
    public class UserRepository : IUserRepository
    {
        Context Context;

        public UserRepository(Context context)
        {
            Context = context;
        }

        public async Task<Guid> PostAsync(User user)
        {
            var newUser = new User()
            {
                FIO = user.FIO,
                IsClient = user.IsClient,
                IsProvider = user.IsProvider,
            };
            await Context.AddAsync(newUser);
            await Context.SaveChangesAsync();
            return newUser.Id;
        }
    }
}
