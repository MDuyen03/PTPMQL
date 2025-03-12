using Microsoft.EntityFrameworkCore;
using MvcMovie.Models; // Đảm bảo đúng namespace chứa Model của bạn

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Daily> Daily { get; set; } 
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get;}
        public DbSet<MvcMovie.Models.Person> Person { get; set; } = default!;
        public DbSet<MvcMovie.Models.Employee> Employee { get; set; } = default!;
    }
}