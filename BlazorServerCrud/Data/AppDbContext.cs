using Microsoft.EntityFrameworkCore;
using BlazorServerCrud.Models;

namespace BlazorServerCrud.Data;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
    {}

    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }
}