using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Persistence;

public class DataContext : DbContext
{
    public DbSet<Province> Provinces { get; set; }
    public DbSet<PriceHistory> PriceHistories { get; set; }
}