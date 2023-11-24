using Business_Layer;
using Service_Layer.Implementation;
using Service_Layer.Interface;

namespace Api_Authentication
{
    public static class ServiceExtension
    {
        public static void DIScope(this IServiceCollection service)
        {
            service.AddScoped<ICategory, CategoryImpl>();
            service.AddScoped<CategoryBLL>();
        }
    }
}
