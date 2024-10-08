using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class TypeProduct : Interfaces.IConvertModel<TypeProduct, Api.DataBase.Models.TypeProduct>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Api.DataBase.Models.TypeProduct ConvertBLLToDALModel(TypeProduct DTOModel)
        {
            return new()
            {
                Name = DTOModel.Name,
                Id = DTOModel.Id
            };
        }

        public TypeProduct ConvertDALToDTOModel(Api.DataBase.Models.TypeProduct DALModel)
        {
            return new()
            {
                Name = DALModel.Name,
                Id = DALModel.Id
            };
        }
    }
}
