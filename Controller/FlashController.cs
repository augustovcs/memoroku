using Memoroku.Models;
using Memoroku.Services;
using Microsoft.AspNetCore.Mvc;

namespace Memoroku.Controller;

[ApiController]
[Route("[controller]")]
public class FlashController : ControllerBase
{
    
    private readonly FlashService _flashService;

    public FlashController(FlashService flashService)
    {
        _flashService = flashService;
    }

    [HttpGet("/flash-per-card")]
    public async Task<IActionResult> FlashPerCard([FromQuery] int cardId)
    {
        var result = await _flashService.GetAllFlashByCard(cardId);
        
        return Ok(result);
    }
    
    
}