using Microsoft.EntityFrameworkCore;
using estudoAPI.Models;
namespace estudoAPI.Data

{
    public class AppDbContext : DbContext
    {    
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
