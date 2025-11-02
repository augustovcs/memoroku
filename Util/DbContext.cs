using Memoroku.Models;
using Microsoft.EntityFrameworkCore;
namespace Memoroku.Util;

public class SupaDB : DbContext
{
    public SupaDB(DbContextOptions<SupaDB> options) : base(options)
    {
        
    }
    
    public DbSet<DataCard> DataCards { get; set; }
    
}