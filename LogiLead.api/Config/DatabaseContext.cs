using LogiLead.api.Data;
using Microsoft.EntityFrameworkCore;

namespace LogiLead.api.Config
{
    public static class DatabaseContext
    {
        public static void AddContext(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<LogiLeadContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("localConnection"))
            );
        }
    }
}
