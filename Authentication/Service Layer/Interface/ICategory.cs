using DTO.Category;
using Helper.CommomModel;

namespace Service_Layer.Interface
{
    public interface ICategory
    {
        public CommonResponse GetAllCategory();

        public CommonResponse GetCategory(GetApiReqDTO getApiReqDTO);
    }
}
