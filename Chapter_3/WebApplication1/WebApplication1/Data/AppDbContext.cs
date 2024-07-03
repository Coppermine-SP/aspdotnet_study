using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}