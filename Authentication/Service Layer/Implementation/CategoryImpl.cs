using Business_Layer;
using DTO.Category;
using Helper.CommomModel;
using Service_Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Implementation
{
    public class CategoryImpl :ICategory
    {
        public readonly CategoryBLL _categoryBLL;
        public CategoryImpl(CategoryBLL categoryBLL)
        {
            _categoryBLL = categoryBLL;
        }
        public CommonResponse GetAllCategory()
        {
            return _categoryBLL.GetAllCategory();
        }

        public CommonResponse GetCategory(GetApiReqDTO getApiReqDTO)
        {
            return _categoryBLL.GetCategory(getApiReqDTO);
        }
    }
}
