using Microsoft.EntityFrameworkCore;

namespace CadastroApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cadastro> Cadastros { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=meuBanco;User=root;Password=krtb3qvd;", 
                new MySqlServerVersion(new Version(8, 0, 39)));
        }
    }
}
