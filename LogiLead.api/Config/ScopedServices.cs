using LogiLead.api.Services;

namespace LogiLead.api.Config
{
    public static class ScopedServices
    {
        public static void RegisterScopedServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<HashService>();
        }
    }
}
