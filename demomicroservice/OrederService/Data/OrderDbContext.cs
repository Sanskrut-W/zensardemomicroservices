using Microsoft.EntityFrameworkCore;
using OrederService.Models;
namespace OrederService.Data
{
    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
    }
}
