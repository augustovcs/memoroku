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

}