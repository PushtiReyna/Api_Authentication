using Data_Layer.Entities;
using DTO.Category;
using Helper.CommomModel;
using Mapster;
using Microsoft.Extensions.Configuration;


namespace Business_Layer
{
    public class CategoryBLL
    {
        public readonly IConfiguration _configuration;

        public readonly UserApidbContext _db;
        public CategoryBLL(UserApidbContext db,IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        public CommonResponse GetAllCategory()
        {
            CommonResponse response = new CommonResponse();
            try
            {
                List<GetCategoryResDTO> lstGetCategoryResDTO = _db.CategoryMsts.Where(u => u.IsDelete == false).ToList().Adapt<List<GetCategoryResDTO>>();


                if (lstGetCategoryResDTO.Count > 0)
                {
                    response.Data = lstGetCategoryResDTO;
                    response.Status = true;
                    response.Message = "category list is found.";
                    response.StatusCode = System.Net.HttpStatusCode.OK;
                }
                else
                {
                    response.Message = "category list is not found";
                    response.StatusCode = System.Net.HttpStatusCode.NotFound;
                }
            }
            catch { throw; }

            return response;
        }

        public CommonResponse GetCategory(GetApiReqDTO getApiReqDTO)
        {
            CommonResponse response = new CommonResponse();
            try
            {
                var apiValue = getApiReqDTO.Api_Key;

                // getApiReqDTO.Api_Key = _configuration["Authentication:ApiKey"];

                if (_configuration["Authentication:ApiKey"] != null && apiValue == _configuration["Authentication:ApiKey"])
                {

                    //List<GetCategoryResDTO> lstGetCategoryResDTO = _db.CategoryMsts.Where(u => u.IsDelete == false).ToList().Adapt<List<GetCategoryResDTO>>();


                    //if (lstGetCategoryResDTO.Count > 0)
                    //{
                    //    response.Data = lstGetCategoryResDTO;
                        response.Status = true;
                        response.Message = "api key is valid";
                        response.StatusCode = System.Net.HttpStatusCode.OK;
                    //}
                }
                else
                {
                    response.Message = "api key is not valid";
                    response.StatusCode = System.Net.HttpStatusCode.NotFound;
                }
            }
            catch { throw; }

            return response;
        }

    }
}
