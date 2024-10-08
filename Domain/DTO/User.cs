using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class User : Interfaces.IConvertModel<User, Api.DataBase.Models.User>
    {
        public Guid Id { get; set; }
        public bool IsClient { get; set; }
        public bool IsProvider { get; set; }
        public string FIO { get; set; }

        public Api.DataBase.Models.User ConvertBLLToDALModel(User DTOModel)
        {
            return new()
            {
                FIO = DTOModel.FIO,
                Id = DTOModel.Id,
                IsClient = DTOModel.IsClient,
                IsProvider = DTOModel.IsProvider,
            };
        }

        public User ConvertDALToDTOModel(Api.DataBase.Models.User DALModel)
        {
            return new()
            {
                FIO = DALModel.FIO,
                Id = DALModel.Id,
                IsClient = DALModel.IsClient,
                IsProvider = DALModel.IsProvider,
            };
        }
    }
}
