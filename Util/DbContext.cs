using Memoroku.Models;
using Microsoft.EntityFrameworkCore;
namespace Memoroku.Util;

public class SupaDB : DbContext
{
    public SupaDB(DbContextOptions<SupaDB> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DataCard>().ToTable("daily_card", schema: "data");
        modelBuilder.Entity<DataFlash>().ToTable("flash_list", schema: "data");
    }

    
    public DbSet<DataCard> DataCards { get; set; }
    public DbSet<DataFlash> DataFlashes { get; set; }
    
}