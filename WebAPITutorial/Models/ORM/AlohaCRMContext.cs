using Microsoft.EntityFrameworkCore;

namespace WebAPITutorial.Models.ORM
{
    public class AlohaCRMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EET2RGT; Database=AlohaCRM;trusted_connection=true");
        }
        public DbSet<WebUser> WebUsers { get; set; }
    }
}
