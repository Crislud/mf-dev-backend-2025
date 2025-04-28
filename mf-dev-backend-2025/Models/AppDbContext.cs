using mf_dev_backend_2025.Models;
using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2025
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}