using Memoroku.Models;
using Microsoft.AspNetCore.Mvc;
using Memoroku.Services;
namespace Memoroku.Controller;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly TestUseful _testUseful;

    public TestController(TestUseful testUseful)
    {
        _testUseful = testUseful;
    }


    [HttpGet("get-row")]
    public async Task<IActionResult> GetRow()
    {
        var row = await _testUseful.GetDataCards();

        if (row == null)
        {
            throw new Exception("DataCard not found");
        }
        
        return Ok(row);
    }

    [HttpPost("add-flash")]
    public async Task<IActionResult> AddFlash([FromBody] DataFlash flash)
    {
        if (flash == null)
        {
            throw new ArgumentNullException(nameof(flash));
        }

        var created = await _testUseful.CreateDataFlashTest(flash);
        return Ok(created);

    }


}