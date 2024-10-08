using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Interfaces
{
    public interface IConvertModel<DTOModel, DALModel>
    {
        DTOModel ConvertDALToDTOModel(DALModel DALModel);
        DALModel ConvertBLLToDALModel(DTOModel DTOModel);
    }
}
