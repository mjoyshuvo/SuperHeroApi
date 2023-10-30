using Microsoft.EntityFrameworkCore;

namespace SuperHeroApi.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=superherodb;UID=SA;PWD=cefAl01q2w3e;Encrypt=False");
    }

    public DbSet<SuperHero> SuperHeroes { get; set; }

    
}