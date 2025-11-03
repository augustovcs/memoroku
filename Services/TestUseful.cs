using Memoroku.Models;
using Memoroku.Util;
using Microsoft.EntityFrameworkCore;
namespace Memoroku.Services;

public class TestUseful
{
    private readonly SupaDB _context;

    public TestUseful(SupaDB context)
    {
        _context = context;
    }

    public async Task<DataCard> GetDataCards()
    {
        var row = await _context.DataCards
            .OrderBy(c => c.Id)
            .FirstOrDefaultAsync();

        return row;
    }

    public async Task<bool> CreateDataFlashTest(DataFlash data)
    {
        var flash = await _context.DataCards
            .AnyAsync(p => p.Id == data.CardId);

        if (!flash)
        {
            return false;
        }
        
        data.Id = Guid.NewGuid();
        data.CreatedAt = DateTime.UtcNow;

        _context.DataFlashes.Add(data);
        await _context.SaveChangesAsync();
        
        return true;

    }

}