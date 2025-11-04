using Memoroku.Models;
using Memoroku.Util;
using Microsoft.EntityFrameworkCore;

namespace Memoroku.Services;

public class FlashService
{

    private readonly SupaDB _context;

    public FlashService(SupaDB context)
    {
        _context = context;
    }

    public async Task<List<string>> GetAllFlashByCard(int card)
    {

        var flash = await _context.DataFlashes
            .Where(c => c.CardId == card)
            .Select(f => f.FlashString)
            .ToListAsync();
        
        return flash;
        
    }



}