using Microsoft.EntityFrameworkCore;

namespace LogiLead.api.Data
{
    public class LogiLeadContext : DbContext
    {
        public LogiLeadContext(DbContextOptions<LogiLeadContext> options) : base(options)
        {}
    }
}
