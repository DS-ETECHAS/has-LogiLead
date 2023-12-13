using LogiLead.api.Models;
using Microsoft.EntityFrameworkCore;

namespace LogiLead.api.Data
{
    public class LogiLeadContext : DbContext
    {
        public LogiLeadContext(DbContextOptions<LogiLeadContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserData> UserDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserData)
                .WithOne(ud => ud.User)
                .HasForeignKey<UserData>(ud => ud.UserId);
        }
    }
}
