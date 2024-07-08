using Cg1119ProfileBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace Cg1119ProfileBlog.Data;

public class AppDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data source=database.db");
}