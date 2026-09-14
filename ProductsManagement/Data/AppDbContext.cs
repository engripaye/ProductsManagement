using Microsoft.EntityFrameworkCore;
using ProductsManagement.Models;

namespace ProductsManagement.Data;


public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    
    public DbSet<Product> Products => Set<Models.Product>();
    
}   