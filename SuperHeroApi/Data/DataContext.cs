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
        optionsBuilder.UseSqlServer("Server=localhost,3306;Database=superherodb;User Id=root;Password=1q2w3e4r5t6y;");
    }

    public DbSet<SuperHero> SuperHeroes { get; set; }

    
}