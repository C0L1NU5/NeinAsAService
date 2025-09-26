using Microsoft.EntityFrameworkCore;
using NeinAsAService.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Answer> Answers { get; set; } = null!;
}
