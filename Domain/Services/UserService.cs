using Api.DataBase;
using Api.DataBase.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UserService
    {
        UserRepository Repository { get; set; }

        public UserService(UserRepository repository)
        {
            Repository = repository;
        }

        public async Task<Guid> PostAsync(DTO.User user)
        {
            return await Repository.PostAsync(user.ConvertBLLToDALModel(user));
        }
    }
}
