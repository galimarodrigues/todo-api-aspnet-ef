using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Data;

public class AppDataContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=app.db;Cache=Shared");
        }
    }
}