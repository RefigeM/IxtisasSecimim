using Ixtisas_Secimim.Services.Abstracts;
using Ixtisas_Secimim.Services.Implements;

namespace Ixtisas_Secimim
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            return services;    
        }
    }
}
