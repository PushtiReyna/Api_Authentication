using Api_Authentication.ViewModel;
using DTO.Category;
using Helper.CommomModel;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_Layer.Interface;

namespace Api_Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly ICategory _Category;
        public CategoryController(ICategory Category)
        {
            _Category = Category;
        }

        [HttpGet]
        //[Route("[HeaderBasedAuthentication]")]
        public CommonResponse GetAllCategory()
        {
            CommonResponse response = new CommonResponse();
            try
            {
                response = _Category.GetAllCategory();
                List<GetCategoryResDTO> lstGetCategoryResDTO = response.Data;
                response.Data = lstGetCategoryResDTO.Adapt<List<GetCategoryResViewModel>>();
            }
            catch { throw; }
            return response;
        }

        [HttpPost]
        //[Route("[BodyBasedAuthentication]")]
        public CommonResponse GetCategory(GetApiReqViewModel getApiReqViewModel)
        {
            CommonResponse response = new CommonResponse();
            try
            {
                response = _Category.GetCategory(getApiReqViewModel.Adapt<GetApiReqDTO>());
                GetApiResDTO getApiResDTO = response.Data;
                response.Data = getApiResDTO.Adapt<GetApiResViewModel>();
            }
            catch { throw; }
            return response;
        }
    }
}
